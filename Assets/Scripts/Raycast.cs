using UnityEngine;
using UnityEngine.EventSystems;

public class Raycast : MonoBehaviour
{
    public Camera raycastCamera;

    void Update()
    {
        // Gambar garis ray sebagai debug
        Debug.DrawRay(raycastCamera.transform.position, raycastCamera.transform.forward * 100, Color.green);

        if (Input.GetMouseButtonDown(0)) // Bisa diganti dengan input VR nantinya
        {
            Ray ray = new Ray(raycastCamera.transform.position, raycastCamera.transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Debug nama objek yang kena ray
                Debug.Log("Ray hit: " + hit.collider.name);

                // Coba panggil event click jika itu UI
                var pointer = new PointerEventData(EventSystem.current);
                ExecuteEvents.Execute(hit.collider.gameObject, pointer, ExecuteEvents.pointerClickHandler);
            }
        }
    }
}
