using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(RawImage))]
public class Parallax : MonoBehaviour
{
    [SerializeField] private float _speed;
    private RawImage _rawImage;
    private float _imagePositionX;
    // Start is called before the first frame update
    void Start()
    {
        _rawImage = GetComponent<RawImage>();
        _imagePositionX = _rawImage.uvRect.x;
    }

    // Update is called once per frame
    void Update()
    {
        _imagePositionX += _speed * Time.deltaTime;

        if (_imagePositionX > 1)
            _imagePositionX = 0;

        _rawImage.uvRect = new Rect(_imagePositionX, 0 ,_rawImage.uvRect.width, _rawImage.uvRect.height);
    }
}
