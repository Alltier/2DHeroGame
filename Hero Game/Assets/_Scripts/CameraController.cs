using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private PlayerMovement playerMovement;


    private void LateUpdate()
    {
        transform.position = new Vector3(playerMovement.GetPlayerPosition().x, playerMovement.GetPlayerPosition().y, transform.position.z);
    }
}
