using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class resetscore : MonoBehaviour
{

    [SerializeField] private FloatSO scoreSO;
    void Start()
    {
        scoreSO.Value = 0;   
    }

}
