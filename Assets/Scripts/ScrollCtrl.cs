using UnityEngine;
using Cinemachine;

public class ScrollCtrl : MonoBehaviour
{

    [Header("プレイヤーゲームオブジェクト")] public GameObject playerObj;

    Player player;
    Transform pTransform;
    CinemachineVirtualCamera cvc;
    float _maxPos = 0f;

    void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        player = playerObj.GetComponent<Player>();
        pTransform = playerObj.transform;
        _maxPos = pTransform.position.y;
        cvc = this.GetComponent<CinemachineVirtualCamera>();
        // GManager.instance.MaxPosUpdate();
        // MaxPosObj.transform.position = new Vector3(pTransform.position.x, pTransform.position.y, pTransform.position.z);

    }
    void LateUpdate()
    {
        // if (GManager.instance == null) {
        //     Debug.Log("GManager.instance NULL!!");
        // }
        // プレイヤーのY方向の最高位置を取得
        if (GManager.instance.GetMaxPos() < transform.position.y)
        {
            Debug.Log("cameraより低い");
        }
        else
        {
            MoveCamera();
        }

    }

    void MoveCamera()
    {
        //transform.position = new Vector3(transform.position.x, _playerPos, transform.position.z);
    }
}
