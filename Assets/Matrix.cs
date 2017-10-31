using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix : MonoBehaviour {

    public GameObject kubPrefab;
    
    public float size = 0f;
    public float colorRange = 1530f;
    public float drawnParticles;

    // Use this for initialization
    void Start () {
        DrawMatrix();
    }
	
	// Update is called once per frame
	void Update () {
		// make methods to configure matrix in runtime
	}

    void DrawMatrix()
    {
        float changeRate = colorRange / (size * size * size);
        float mod = changeRate / 2000;
        for (int x = 0; x <= size; x++)
            {
                for (int y = 0; y <= size; y++)
                {
                    for (int z = 0; z <= size; z++)
                    {
                        
                        GameObject kub = Instantiate(kubPrefab, new Vector3(x,y,z), Quaternion.identity);
                        
                    
                        kub.GetComponent<MeshRenderer>().materials[0].color = Color.HSVToRGB(mod, 0.8f, 1f);
                        mod += changeRate / 2000;
                    }
                }
            }
        }

    Color getNextColor()
    {
        float changeRate = colorRange/(size*size*size);
        Color result = new Color(255,255,255);

        if (drawnParticles > -1 && drawnParticles < 256)
        {
            result = new Color(255, 0, drawnParticles);
            print("255,0,dP" + drawnParticles*changeRate);
        }else if(drawnParticles > 255 && drawnParticles < 510)
        {
            print("dp,0,255");
            result = new Color(255 - (drawnParticles - 255), 0, 255, 125);
        }else if(drawnParticles > 510 && drawnParticles < 765)
        {
            print("0,dp,255");
            result = new Color(0, 0 + (drawnParticles - 510), 255, 125);
        }
        else if (drawnParticles > 765 && drawnParticles < 1020)
        {
            print("0,255,dp");
            result = new Color(0, 255, 255 - (drawnParticles - 765), 125);
        }
        else if(drawnParticles > 1020 && drawnParticles < 1275)
        {
            print("dp,255,0");
            result = new Color(0 + (drawnParticles - 1020),255, 0, 125);
        }
        else if (drawnParticles > 1275 && drawnParticles < 1530)
        {
            print("255,dp,0");
            result = new Color(255, 255 - (drawnParticles - 1275), 0, 125);
        }

        drawnParticles++;
        return result;
    }
}