using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float turnSpeed = 100.0f;
    public float forwardSpeed = 10.0f;
   private void Update()
   {
    // Kullanıcıdan gelen yatay girdiyi al
    float horizontalInput = Input.GetAxis("Horizontal");
    // Kullanıcıdan gelen dikey girdiyi al
    float verticalInput = Input.GetAxis("Vertical");

    // Arabanın dönüşünü yatay girdiye göre kontrol et
    transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime * turnSpeed);

    // Arabanın ileri ve geri hareketini dikey girdiye göre kontrol et
    transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * forwardSpeed);
  }
}