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

  public static int wrongNum=0;


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
      public int checkUsd=0;
      public Text wrongShow;
      public Text CheckUsed;

      public Animation anim;

      public bool starting = true;
 
 
 
 
  void Start ()
  {
      anim = gameObject.GetComponent<Animation>();
      GameTime.StartTimer();
      CheckUsed.text = checkUsd.ToString();
  }
    void Update()
    {
        wrongShow.text = wrongNum.ToString();
        if (checkA(A, Afill) && checkB(B, Bfill) && checkC(C, Cfill) &&
            checkD(D, Dfill) && checkE(E, Efill) && checkF(F, Ffill) &&
            checkG(G, Gfill) && checkH(H, Hfill) && checkI(I, Ifill)&& starting)

        {
            anim.Play("Anim");
            starting = false;
        }
       
        
        

        
    }
    bool checkA(InputField[] A,int[] Afill)
    {
        int n = 0;
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i].text == Afill[i].ToString())
            {
                n++;
            }

        }

        if (n == A.Length)
        {
            return true;
        }
            return false;
        }
    bool checkB(InputField[] B,int[] Bfill)
    {
        int n = 0;
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i].text == Bfill[i].ToString())
            {
                n++;
            }
        }

        if (n == B.Length)
        {
            return true;
        }
        return false;
    }
    
    bool checkC(InputField[] C,int[] Cfill)
    {
        int n = 0;
        for (int i = 0; i < C.Length; i++)
        {
            if (C[i].text == Cfill[i].ToString())
            {
                n++;
            }
            
        }

        if (n == C.Length)
        {
            return true;
        }
        return false;
    }
    bool checkD(InputField[] D,int[] Dfill)
    {
        int n = 0;
        for (int i = 0; i < D.Length; i++)
        {
            if (D[i].text == Dfill[i].ToString())
            {
                n++;
            }
           
        }

        if (n == D.Length)
        {
            return true;
        }
        return false;
    }
    bool checkE(InputField[] E,int[] Efill)
    {
        int n = 0;
        for (int i = 0; i < E.Length; i++)
        {
            if (E[i].text == Efill[i].ToString())
            {
                n++;
            }
           
        }

        if (n == E.Length)
        {
            return true;
        }
        return false;
    }
    bool checkF(InputField[] F,int[] Ffill)
    {
        int n = 0;
        for (int i = 0; i < F.Length; i++)
        {
            if (F[i].text == Ffill[i].ToString())
            {
                n++;
            }
            
        }

        if (n == F.Length)
        {
            return true;
        }
        return false;
    }
    bool checkG(InputField[] G,int[] Gfill)
    {
        int n = 0;
        for (int i = 0; i < G.Length; i++)
        {
            if (G[i].text == Gfill[i].ToString())
            {
                n++;
            }
            
        }
        if (n == G.Length)
        {
            return true;
        }
        return false;
    }
    bool checkH(InputField[] H,int[] Hfill)
    {
        int n = 0;
        for (int i = 0; i < H.Length; i++)
        {
            if (H[i].text == Hfill[i].ToString())
            {
                n++;
            }
            
        }

        if (n == H.Length)
        {
            return true;
        }
        return false;
    }
    bool checkI(InputField[] I,int[] Ifill)
    {
        int n = 0;
        for (int i = 0; i < I.Length; i++)
        {
            if (I[i].text == Ifill[i].ToString())
            {
                n++;
            }
            
            
        }

        if (n == I.Length)
        {
            return true;
        }
        return false;
    }






    public void checkWrong()
    {
        checkUsd++;
        CheckUsed.text = checkUsd.ToString();
        checkAWrong(A,Afill);
        checkBWrong(B,Bfill);
        checkCWrong(C,Cfill);
        checkDWrong(D,Dfill);
        checkEWrong(E,Efill);
        checkFWrong(F,Ffill);
        checkGWrong(G,Gfill);
        checkHWrong(H,Hfill);
        checkIWrong(I,Ifill);
    }
    
    
    
    
    
    
    void checkAWrong(InputField[] A,int[] Afill)
    {
        for (int i = 0; i < A.Length; i++)
        {
            if (A[i].text != "")
            {

                if (A[i].text != Afill[i].ToString())
                        {
                            wrongNum++;
                            A[i].image.color = Color.red;
                        }
                       
                    
                    else
                    {
                        A[i].image.color = Color.white;

                    }
                }
            
        }
    }
    void checkBWrong(InputField[] B,int[] Bfill)
    {
        for (int i = 0; i < B.Length; i++)
        {
            if (B[i].text != "")
            {
                if (B[i].text != Bfill[i].ToString())
                {
                    wrongNum++;

                    B[i].image.color = Color.red;
                }
                else
                {
                    B[i].image.color = Color.white;

                }
            }
        }
    }
    void checkCWrong(InputField[] C,int[] Cfill)
    {
        
        for (int i = 0; i < C.Length; i++)
        {
            if (C[i].text != "")
            {
                if (C[i].text != Cfill[i].ToString())
                {
                    wrongNum++;

                    C[i].image.color = Color.red;
                }
                else
                {
                    C[i].image.color = Color.white;

                }
            }
        }
    }
    void checkDWrong(InputField[] D,int[] Dfill)
    {
        for (int i = 0; i < D.Length; i++)
        {
            if (D[i].text != "")
            {
                if (D[i].text != Dfill[i].ToString())
                {
                    wrongNum++;

                    D[i].image.color = Color.red;
                }
                else
                {
                    D[i].image.color = Color.white;

                }
            }
        }
    }
    void checkEWrong(InputField[] E,int[] Efill)
    {
        for (int i = 0; i < E.Length; i++)
        {
            if (E[i].text != "")
            {
                if (E[i].text != Efill[i].ToString())
                {
                    wrongNum++;

                    E[i].image.color = Color.red;
                }
                else
                {
                    E[i].image.color = Color.white;

                }
            }
        }
    }
    void checkFWrong(InputField[] F,int[] Ffill)
    {
        for (int i = 0; i < F.Length; i++)
        {
            if (F[i].text != "")
            {
                if (F[i].text != Ffill[i].ToString())
                {
                    wrongNum++;

                    F[i].image.color = Color.red;
                }
                else
                {
                    F[i].image.color = Color.white;

                }
            }
        }
    }
    void checkGWrong(InputField[] G,int[] Gfill)
    {
        for (int i = 0; i < G.Length; i++)
        {
            if (G[i].text != "")
            {
                if (G[i].text != Gfill[i].ToString())
                {
                    wrongNum++;

                    G[i].image.color = Color.red;
                }
                else
                {
                    G[i].image.color = Color.white;

                }
            }
        }
    }
    void checkHWrong(InputField[] H,int[] Hfill)
    {
        for (int i = 0; i < H.Length; i++)
        {
            if (H[i].text != "")
            {
                if (H[i].text != Hfill[i].ToString())
                {
                    wrongNum++;

                    H[i].image.color = Color.red;
                }
                else
                {
                    H[i].image.color = Color.white;

                }
            }
        }
    }
    void checkIWrong(InputField[] I,int[] Ifill)
    {
        for (int i = 0; i < I.Length; i++)
        {
            if (I[i].text != "")
            {
                if (I[i].text != Ifill[i].ToString())
                {
                    wrongNum++;

                    I[i].image.color = Color.red;
                }
                else
                {
                    I[i].image.color = Color.white;

                }
            }
        }
    }
    
}

