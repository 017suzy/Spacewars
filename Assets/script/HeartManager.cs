using UnityEngine;
using UnityEngine.UI;

public class HeartManager : MonoBehaviour
{
        public Image[] hearts;
        public Sprite vidasOn;
        public Sprite vidasOff;
        public FloatValue heartContainers;
        public FloatValue playerCurrentHealth;

        void Start(){
            InitHearts();
        }
        public void InitHearts(){
            for(int i = 0; i <  heartContainers.initialValue; i++){
                hearts[i].gameObject.SetActive(true);
                hearts[i].sprite = vidasOn;
            }

        }

        void Update(){
             float tempHealth = playerCurrentHealth.RuntimeValue;
             
            for (int i = 0; i<heartContainers.RuntimeValue; i++){
                if(i<=tempHealth){
                    hearts[i].sprite = vidasOn;

                }
                else{
                    hearts[i].sprite = vidasOff;                    
                }
            }
        }
        public void UpdateHearts(){
            float tempHealth = playerCurrentHealth.RuntimeValue;
             
            for (int i = 0; i<heartContainers.RuntimeValue; i++){
                if(i<=tempHealth){
                    hearts[i].sprite = vidasOn;

                }
                else{
                    hearts[i].sprite = vidasOff;                    
                }
            }
        }
        
    
}
