using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class checkEach : MonoBehaviour
{
   public InputField A2;
  public InputField A3;
  public InputField A5;   
  public InputField A6;
  public InputField A7;
  public InputField A9;
  public InputField B1;
  public InputField B3;
  public InputField B4;
  public InputField B7;
  public InputField B9;
  public InputField C1;
  public InputField C6;
 public  InputField C7;
  public InputField C8;
  public InputField D2;
   public InputField D4;
  public InputField D5;
  public InputField D7;
  public InputField E1;
  public InputField E3;
  public InputField E9;
  public InputField F4;
  public InputField F5;
  public InputField F6;
  public InputField F7;
  public InputField F9;
  public InputField G1;
  public InputField G2;
  public InputField G4;
  public InputField G5;
 public  InputField G7;
  public InputField G8;
  public InputField H6;
  public InputField H9;
  public InputField I1;
  public InputField I2;
  public InputField I4;
  public InputField I7;
  public InputField I8;
  public InputField I9;
  public GameObject img;
  void Start ()
  {
      GameTime.StartTimer();
  }
    void Update()
    {
        if (checkA2() && checkA3() && checkA5() && checkA6() && checkA7() && checkA9() && checkB1() && checkB3() && checkB4() && checkB7() && checkB9() && checkC1() && checkC6() && checkC7() && checkC8() && checkD2() && checkD4() && checkD5() && checkD7() && checkE1() && checkE3() && checkE9() && checkF4() && checkF5() && checkF6() && checkF7() && checkF9() && checkG1() && checkG2() && checkG4() && checkG5() && checkG7() && checkG8() && checkH6() && checkH9() && checkI1() && checkI2() && checkI4() && checkI7() && checkI8() && checkI9())
        {
            img.gameObject.SetActive(true);
            Debug.Log("y");
        }
    }
    bool checkA2()
    {
        if (A2.text == "2")
        {
        
            return true;
        }

        return false;
    }
    bool checkA3()
    {
        if (A3.text == "7")
        {
            return true;
        }

        return false;
    }
    bool checkA5()
    {
        if (A5.text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkA6()
    {
        if (A6.text == "4")
        {
            return true;
        }

        return false;
    }
    bool checkA7()
    {
        if (A7.text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkA9()
    {
        if (A9.text == "6")
        {
            return true;
        }

        return false;
    }
    bool checkB1()
    {
        if (B1.text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkB3()
    {
        if (B3.text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkB4()
    {
        if (B4.text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkB7()
    {
        if (B7.text == "1")
        {
            return true;
        }

        return false;
    }
    bool checkB9()
    {
        if (B9.text == "8")
        {
            return true;
        }

        return false;
    }
    bool checkC1()
    {
        if (C1.text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkC6()
    {
        if (C6.text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkC7()
    {
        if (C7.text == "7")
        {
            return true;
        }

        return false;
    }
    bool checkC8()
    {
        if (C8.text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkD2()
    {
        if (D2.text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkD4()
    {
        if (D4.text == "4")
        {
            return true;
        }

        return false;
    }
    bool checkD5()
    {
        if (D5.text == "6")
        {
            return true;
        }

        return false;
    }
    bool checkD7()
    {
        if (D7.text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkE1()
    {
        if (E1.text == "4")
        {
            return true;
        }

        return false;
    }
    bool checkE3()
    {
        if (E3.text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkE9()
    {
        if (E9.text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkF4()
    {
        if (F4.text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkF5()
    {
        if (F5.text == "7")
        {
            return true;
        }

        return false;
    }
    bool checkF6()
    {
        if (F6.text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkF7()
    {
        if (F7.text == "4")
        {
            return true;
        }

        return false;
    }
    bool checkF9()
    {
        if (F9.text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkG1()
    {
        if (G1.text == "7")
        {
            return true;
        }

        return false;
    }
    bool checkG2()
    {
        if (G2.text == "8")
        {
            return true;
        }

        return false;
    }
    bool checkG4()
    {
        if (G4.text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkG5()
    {
        if (G5.text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkG7()
    {
        if (G7.text == "9")
        {
            return true;
        }

        return false;
    }
    bool checkG8()
    {
        if (G8.text == "1")
        {
            return true;
        }

        return false;
    }
    bool checkH6()
    {
        if (H6.text == "6")
        {
            return true;
        }

        return false;
    }
    bool checkH9()
    {
        if (H9.text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkI1()
    {
        if (I1.text == "2")
        {
            return true;
        }

        return false;
    }
    bool checkI2()
    {
        if (I2.text == "3")
        {
            return true;
        }

        return false;
    }
    bool checkI4()
    {
        if (I4.text == "8")
        {
            return true;
        }

        return false;
    }
    bool checkI7()
    {
        if (I7.text == "5")
        {
            return true;
        }

        return false;
    }
    bool checkI8()
    {
        if (I8.text == "6")
        {
            return true;
        }

        return false;
    }
    bool checkI9()
    {
        if (I9.text == "7")
        {
            return true;
        }

        return false;
    }
}
