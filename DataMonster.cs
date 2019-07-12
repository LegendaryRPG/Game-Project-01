using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataMonster : MonoBehaviour
{
    public List<StructMonster> Smonter = new List<StructMonster>();
    
    // Start is called before the first frame update
    void Start(){
        
        void Pk001(){
            //Bulbasaur
            StructMonster P001 = new StructMonster();
            P001.pkId = 1;
            P001.raza = "Bulbasaur";
            P001.especie = "Semilla";
            P001.tipo1 = 11;
            P001.tipo2 = 16;
            P001.hab1 = 28;
            P001.hab2 = 0;
            P001.habO = 13;
            P001.peso = 6.9f; //Kilos
            P001.altura = 0.7f; //Metros
            P001.grupH1 = 11;
            P001.grupH2 = 1;
            P001.genM = 87.5f; //En Porcentaje
            P001.genH = 12.5f;
            P001.habitad = "Pradera";
            //P001.figura =
            //P001.huella = 
            P001.RatExp = 1059860;
            P001.RatCaptura = 45;
            P001.Amisbase = 70;
            P001.eclosHuevo = 21; //cilos de 255 (5355)
            P001.ExpBase = 64;
            P001.LvlEvol = 16;
            P001.EvolId = 2;
            P001.infodex = "Bulbasaur, el Pokemon semilla. Cuando Bulbasaur es joven, se nutre de su semilla para extraer la energía que necesita para crecer";
            P001.Movlvl = new int[] {362,1,339,3,425,7,436,9,590,13,447,13,303,15,432,19,316,21,304,25,313,27,413,31,446,33,419,37,447,41,442,46};//Aprende el movimiento al nivel.
            P001.MovApren = new int[] {594,579,364,138,481,368,407,329,442,383,312,578,344,466,261,277,317,426,307,301,431,291,394,398,216,302,343,288,296,330};
            P001.MovTuto = new int[] {301,247,55,57,337,384,386,336,313,291,527,413,354,394,446,449,398,554,419,430,257};
            P001.MovHuev = new int[] {410,481,407,273,424,169,122,445,434,451,243,416,437,593,435,430,247,421};
            P001.PuntEsfuer = new int[] { 0, 0, 0, 1, 0, 0 };
            P001.Estbase = new int[] { 45, 49, 49, 65, 65, 45 };
            P001.MegaEvol = false;
            Smonter.Add(P001);
        }

    }

    // Update is called once per frame
    void Update(){}
 }
