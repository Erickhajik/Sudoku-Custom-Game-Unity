using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class checkEach : MonoBehaviour
{

  public GameObject Score;
  public GameObject GameBack;




  public InputField[] A;
  public int[] Afill;
  public InputField[] B;
  public int[] Bfill;
      public InputField[] C;
      public int[] Cfill;
      public InputField[] D;
      public int[] Dfill;
      public InputField[] E;
      public int[] Efill;
      public InputField[] F;
      public int[] Ffill;
      public InputField[] G;
      public int[] Gfill;
      public InputField[] H;
      public int[] Hfill;
      public InputField[] I;
      public int[] Ifill;

 
 
 
 
 
 
 
 
 
 
 
  void Start ()
  {
    
      GameTime.StartTimer();
  }
    void Update()
    {
        if (checkA(A, Afill) && checkB(B, Bfill) && checkC(C, Cfill) &&
            checkD(D, Dfill) && checkE(E, Efill) && checkF(F, Ffill) &&
            checkG(G, Gfill) && checkH(H, Hfill) && checkI(I, Ifill))

        {
            GameBack.SetActive(false);
            Score.SetActive(true);
        }
       
    
        

        
    }
    bool checkA(InputField[] A,int[] Afill)
    {
if(A[0].text == Afill[0].ToString() && A[1].text == Afill[1].ToString() && A[2].text == Afill[2].ToString() && A[3].text == Afill[3].ToString() && A[4].text == Afill[4].ToString() && A[5].text == Afill[5].ToString())       
{
       
                return true;
            }
        
            return false;
        }
    bool checkB(InputField[] B,int[] Bfill)
    {
if(B[0].text == Bfill[0].ToString() && B[1].text == Bfill[1].ToString() && B[2].text == Bfill[2].ToString() && B[3].text == Bfill[3].ToString() && B[4].text == Bfill[4].ToString() && B[5].text == Bfill[5].ToString())
{
            
            return true;
        }
        
        return false;
    }
    bool checkC(InputField[] C,int[] Cfill)
    {
if(C[0].text == Cfill[0].ToString() && C[1].text == Cfill[1].ToString() && C[2].text == Cfill[2].ToString() && C[3].text == Cfill[3].ToString() && C[4].text == Cfill[4].ToString() && C[5].text == Cfill[5].ToString())
{
            
            return true;
        }
        
        return false;
    }
    bool checkD(InputField[] D,int[] Dfill)
    {
if(D[0].text == Dfill[0].ToString() && D[1].text == Dfill[1].ToString() && D[2].text == Dfill[2].ToString() && D[3].text == Dfill[3].ToString() && D[4].text == Dfill[4].ToString() && D[5].text == Dfill[5].ToString() && D[6].text == Dfill[6].ToString() && D[7].text == Dfill[7].ToString() && D[8].text == Dfill[8].ToString() )
{
            
            return true;
        }
        
        return false;
    }
    bool checkE(InputField[] E,int[] Efill)
    {
if(E[0].text == Efill[0].ToString() && E[1].text == Efill[1].ToString() && E[2].text == Efill[2].ToString() && E[3].text == Efill[3].ToString())
{
            
            return true;
        }
        
        return false;
    }
    bool checkF(InputField[] F,int[] Ffill)
    {
if(F[0].text == Ffill[0].ToString() && F[1].text == Ffill[1].ToString() && F[2].text == Ffill[2].ToString() && F[3].text == Ffill[3].ToString() && F[4].text == Ffill[4].ToString() && F[5].text == Ffill[5].ToString() && F[6].text == Ffill[6].ToString() && F[7].text == Ffill[7].ToString())
{
            
            return true;
        }
        
        return false;
    }
    bool checkG(InputField[] G,int[] Gfill)
    {
if(G[0].text == Gfill[0].ToString() && G[1].text == Gfill[1].ToString() && G[2].text == Gfill[2].ToString() && G[3].text == Gfill[3].ToString() && G[4].text == Gfill[4].ToString() && G[5].text == Gfill[5].ToString())
{
            
            return true;
        }
        
        return false;
    }
    bool checkH(InputField[] H,int[] Hfill)
    {
if(H[0].text == Hfill[0].ToString() && H[1].text == Hfill[1].ToString() && H[2].text == Hfill[2].ToString() && H[3].text == Hfill[3].ToString() && H[4].text == Hfill[4].ToString() && H[5].text == Hfill[5].ToString())
{
            
            return true;
        }
        
        return false;
    }
    bool checkI(InputField[] I,int[] Ifill)
    {
if(I[0].text == Ifill[0].ToString() && I[1].text == Ifill[1].ToString() && I[2].text == Ifill[2].ToString() && I[3].text == Ifill[3].ToString() && I[4].text == Ifill[4].ToString() && I[5].text == Ifill[5].ToString())
{
            
            return true;
        }
        
        return false;
    }

}

