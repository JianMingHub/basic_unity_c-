using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Khai báo delegate
public delegate void ChangeColorDelegate(Color newColor);
public class ColorChanger : MonoBehaviour
{
    // Khai báo một instance của delegate
    public ChangeColorDelegate OnColorChange;

    // Start is called before the first frame update
    void Start()
    {
        // Gán phương thức ChangeColor cho delegate
        OnColorChange = ChangeColor;
    }

    // Update is called once per frame
    void Update()
    {
        // Khi nhấn phím C, thay đổi màu sắc ngẫu nhiên
        if (Input.GetKeyDown(KeyCode.C))
        {
            Color randomColor = new Color(Random.value, Random.value, Random.value);
            // Nếu OnColorChange không phải là null, 
            // thì Phương thức Invoke được gọi trên delegate OnColorChange với tham số randomColor
            OnColorChange?.Invoke(randomColor);
        }
    }
    void ChangeColor(Color newColor)
    {
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = newColor;

        // GetComponent<Renderer>().material.color = newColor;
    }
}
