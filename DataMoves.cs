using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMoves : MonoBehaviour
{
    public List<StructMoves> Smoves = new List<StructMoves>();

    // Start is called before the first frame update
    void Start(){

        void Mov001(){
            //Ala de Acero
            StructMoves M001 = new StructMoves();
            M001.MovId = 001;
            M001.Movname = "Ala de Acero";
            M001.MovPot = 70;
            M001.MovPrec = 90;
            M001.MovPP = 25;
            M001.Movtip = 0;
            M001.MovtipC = 20;
            M001.Movcat = 1;
            M001.MovEfec = "Posibilidad de un 10% de aumentar un punto la defensa propia";
            Smoves.Add(M001);
        }
    }

    // Update is called once per frame
    void Update(){}
}
