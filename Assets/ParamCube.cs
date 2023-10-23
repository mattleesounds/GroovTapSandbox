using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParamCube : MonoBehaviour
{
    public int _band;
    public float _startScale, _scaleMultiplier;
    public bool _useBuffer;
    int _maxHeight = 15;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float newScaleY = Mathf.Clamp((_useBuffer ? AudioScript1._bandBuffer[_band] : AudioScript1._freqBand[_band]) * _scaleMultiplier + _startScale, 0, _maxHeight);
        transform.localScale = new Vector3(transform.localScale.x, newScaleY, transform.localScale.z);
        transform.localPosition = new Vector3(transform.localPosition.x, newScaleY / 2, transform.localPosition.z);
    }



}
