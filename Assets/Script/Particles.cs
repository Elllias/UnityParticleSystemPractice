using UnityEngine;

namespace Script
{
    public class Particles : MonoBehaviour
    {
        private ParticleSystemRenderer _particleSystemRenderer;
        private float _inputX;
    
        private void Start()
        {
            _particleSystemRenderer = GetComponent<ParticleSystemRenderer>();
        }

        private void Update()
        {
            _inputX = Input.GetAxis("Horizontal");

            if (_inputX > 0)
                _particleSystemRenderer.flip = new Vector3(1, 0, 0);
            else if (_inputX < 0)
                _particleSystemRenderer.flip = new Vector3(0, 0, 0);
        }
    }
}
