using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cities : MonoBehaviour
{
    void Miasto1() //brak funkcji z porwaniem towaru
    {
        #region buff
        VariableTag.profit += VariableTag.profit * 0.4f;
        VariableTag.weight += VariableTag.weight * 0.15f;
        #endregion

        #region debuff
        int rnd = Random.Range(0, 100);
        if (rnd >= 0 && rnd <= 35)
        {
            //porwanie towaru
            VariableTag.profit = 0;
        }
        VariableTag.WastedChance += VariableTag.WastedChance * 0.05f;
        VariableTag.BribeChance -= VariableTag.BribeChance * 0.25f;
        VariableTag.BribeValue += VariableTag.BribeValue * 0.2f;
        #endregion


    }
    void Miasto2()
    {

    }
    void Miasto3()
    {
        #region buff
        VariableTag.ConfiscateChance = 0;
        #endregion

        #region debuff
        VariableTag.cash -= VariableTag.StuffValue *0.1f;
        #endregion

    }
    void Miasto4() //brak funkcji z porwaniem towaru
    {
        #region buff
        VariableTag.weight += VariableTag.weight * 1.25f;
        VariableTag.WastedChance += VariableTag.WastedChance * 0.075f;
        VariableTag.BribeValue -= VariableTag.BribeValue * 0.1f;
        #endregion

        #region debuff
        VariableTag.profit -= VariableTag.profit *0.3f;
        int rnd = Random.Range(0, 100);
        if (rnd >= 0 && rnd <= 35)
        {
            //porwanie towaru
            VariableTag.profit =0;
        }
        #endregion


    }
    void Miasto5() //brak wytworni
    {
        #region buff
        //if(wytwornia==metaamfetamina || wytwornia==amfetamina)
        //{
        //    VariableTag.profit += VariableTag.profit * 0.2f;
        //}
        //if (wytwornia == marichuana)
        //{
        //    VariableTag.profit += VariableTag.profit * 0.1f;
        //}
        #endregion

        #region debuff
        VariableTag.WastedChance+= VariableTag.WastedChance *0.15f;
        //if(wytwornia==opium || wytwornia==kokaina)
        //{
        //    VariableTag.profit -= VariableTag.profit * 0.2f;
        //}
        #endregion


    }
    void Miasto6()
    {
        #region buff
        VariableTag.profit += VariableTag.profit *1.5f;
        #endregion

        #region debuff
        VariableTag.StuffAmount -= VariableTag.StuffAmount * 0.55f;
        VariableTag.BribeChance -= VariableTag.BribeChance * 1f;
        #endregion

    }
    void Miasto7()
    {
        #region buff
        VariableTag.TransportCost = 0;
        VariableTag.PaymentChance += VariableTag.PaymentChance *1;
        #endregion

        #region debuff
        VariableTag.profit -= VariableTag.profit *0.45f;
        VariableTag.StuffAmount = VariableTag.MagazineStuffAmount;
        #endregion

    }
}
        //Script By Daniel "MiPiNi" Grala
        //TODO Change comments to actual script: add variables etc
