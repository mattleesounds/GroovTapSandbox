using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate512Cubes : MonoBehaviour
{
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[512];
    public float _maxScale;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 512; i++)
        {
            GameObject _instanceSampleCube = (GameObject)Instantiate(_sampleCubePrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SampleCube" + i;

            this.transform.eulerAngles = new Vector3(0, -0.703125f * i, 0);
            _instanceSampleCube.transform.position = Vector3.forward * 100 + new Vector3(0, 1, 0);
            _sampleCube[i] = _instanceSampleCube;
        }
    }


    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 512; i++)
        {
            if (_sampleCube != null)
            {
                float newScaleY = (AudioScript1._samples[i] * _maxScale) + 2;
                _sampleCube[i].transform.localScale = new Vector3(2, newScaleY, 2);

                // Adjust the cube's local position based on its current scale
                _sampleCube[i].transform.localPosition = new Vector3(_sampleCube[i].transform.localPosition.x, newScaleY / 2, _sampleCube[i].transform.localPosition.z);
            }
        }
    }
}
