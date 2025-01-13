using UnityEngine;
using UnityEngine.UI;

public class HeartManager1 : MonoBehaviour
{
        public Image[] hearts1;
        public Sprite vidasOn;
        public Sprite vidasOff;
        public FloatValue1 heartContainers1;
        public FloatValue1 playerCurrentHealth1;

        void Start(){
            InitHearts();
        }
        public void InitHearts(){
            for(int i = 0; i <  heartContainers1.initialValue1; i++){
                hearts1[i].gameObject.SetActive(true);
                hearts1[i].sprite = vidasOn;
            }

        }

        void Update(){
             float tempHealth = playerCurrentHealth1.RuntimeValue1;
             
            for (int i = 0; i<heartContainers1.RuntimeValue1; i++){
                if(i<=tempHealth){
                    hearts1[i].sprite = vidasOn;

                }
                else{
                    hearts1[i].sprite = vidasOff;                    
                }
            }
        }
        public void UpdateHearts(){
            float tempHealth = playerCurrentHealth1.RuntimeValue1;
             
            for (int i = 0; i<heartContainers1.RuntimeValue1; i++){
                if(i<=tempHealth){
                    hearts1[i].sprite = vidasOn;

                }
                else{
                    hearts1[i].sprite = vidasOff;                    
                }
            }
        }
        
    
}
