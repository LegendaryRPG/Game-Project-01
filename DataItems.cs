using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataItems : MonoBehaviour
{
    public List<StructItems> Sitems = new List<StructItems>();

    // Start is called before the first frame update
    void Start(){

        void Item001(){
            //Bonguri Blanco
            StructItems I001 = new StructItems();
            I001.ItemId = 0;
            I001.ItemName = "Bonguri Blanco";
            I001.ItemCatId = 0;
            I001.ItemCatName = "Bonguri";
            I001.ItemCom = -1;
            I001.ItemVen = -1;
            //I001.ItemImg = 
            I001.ItemDescrip = "Se utiliza para fabricar una Rapid Ball";
        }
    }

    // Update is called once per frame
    void Update(){}
}
