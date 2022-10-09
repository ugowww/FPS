using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PremierComposant : MonoBehaviour
{
    //Parameters
    [SerializeField] private int vitesse;
    [SerializeField] private Vector3 position = new Vector3();
    
    [SerializeField] private GameObject preFabAInstancier;
    [SerializeField] private GameObject centre;
    [SerializeField] private int NombreObjet;
    [SerializeField] private int TailleCercle;
    private int MonTampNbObjet;
    private int MonTampTailleC;
    private int monTampVitesse;
    private List<GameObject> objetgeneres = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        InitInstanciation();
    }

    void InitInstanciation(){
        centre.transform.position = position;
        monTampVitesse = vitesse;
        MonTampTailleC = TailleCercle;
        MonTampNbObjet = NombreObjet;
        for(int i = 0; i<NombreObjet; i++){
            var objet = Instantiate(preFabAInstancier, new Vector3(TailleCercle*Mathf.Sin(((2*Mathf.PI*i)/NombreObjet)), 0f,TailleCercle*Mathf.Cos(((2*Mathf.PI*i)/NombreObjet))) + centre.transform.position, Quaternion.identity); 
            objet.transform.parent = centre.transform;
            objetgeneres.Add(objet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(NombreObjet != MonTampNbObjet || TailleCercle!=MonTampTailleC || monTampVitesse!=vitesse || centre.transform.position!=position){
            foreach(var obj in objetgeneres){
                Destroy(obj);
            }
            InitInstanciation();
        }
        centre.transform.RotateAround(centre.transform.position, new Vector3(0,1,0), Time.deltaTime*vitesse);
       foreach(var obj in objetgeneres){
            //objetgeneres[i].transform.RotateAround(centre.transform.position, new Vector3(0,1,0), Time.deltaTime*vitesse);
            //obj.transform.position = obj.transform.position + new Vector3(-Mathf.Sin(Time.time),0f,Mathf.Cos((Mathf.PI/2) - Time.time))*TailleCercle*Time.deltaTime; 
            //obj.transform.position = obj.transform.position + new Vector3(Mathf.Cos(Time.time),0f,-Mathf.Sin(Time.time))*TailleCercle*Time.deltaTime;       
        }
    }
}
