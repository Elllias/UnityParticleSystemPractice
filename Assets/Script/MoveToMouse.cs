using UnityEngine;

namespace Script
{
    [System.Serializable]
    public class MoveToMouse : MonoBehaviour
    {
        public float Speed = 8.0f;
        public float DistanceFromCamera = 5.0f;

        private void Update()
        {
            var mousePosition = Input.mousePosition;
        
            mousePosition.z = DistanceFromCamera;

            var mouseScreenToWorld = Camera.main.ScreenToWorldPoint(mousePosition);
            var position = Vector3.Lerp(transform.position, mouseScreenToWorld,
                1.0f - Mathf.Exp(-Speed * Time.deltaTime));

            transform.position = position;
        }
    }
}