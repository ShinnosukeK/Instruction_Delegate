using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ydelegate—p“r1zif•¶‚ÌğŒ®‚ğ·‚µ‘Ö‚¦‚é–Ú“I‚Åg—p
public class HowToUseDelegate1 : MonoBehaviour
{
    // Step1: –ß‚è’lboolŒ^Aˆø”intŒ^num‚Ìdelegate Checker‚ğ’è‹`
    public delegate bool Checker(int num);

    // Step2: –ß‚è’l‚È‚µAˆø”‚ğ‡@delegate CheckerŒ^A‡AintŒ^num‚ğæ‚ê‚éCheckŠÖ”‚ğ’è‹`
    void Check(Checker checker, int num) {
        // Step3: if•¶ğŒ”»’è‚ÉAInvoke‚Énum‚ğ—^‚¦‚Ä—˜—p‚·‚é
        // ’Ê‰ß‚µ‚½‚çuˆø”(numjOKvƒ_ƒ‚È‚çuˆø”(num)NGv‚Æo—Í
        if((bool)checker?.Invoke(num)) {
            Debug.Log("ˆø”" + num + "OK");
        } else {
            Debug.Log("ˆø”" + num + "NG");
        }
    }

    void Start() {
        int hp = 5000;

        // Step4: CheckerŒ^checker‚ğ’è‹`‚µACanDefeatZako‚ğ‘ã“ü
        Checker checker = CanDefeatZako;

        // Step5: CheckŠÖ”‚ÉAchecker‚Æhp‚ğ—^‚¦‚ÄŒÄ‚Ô
        Check(checker, hp);

        // Step6: checker‚ÉCanDefeatBoss‚ğÄ‘ã“ü
        checker = CanDefeatBoss;

        // Step7: CheckŠÖ”‚ÉAchecker‚Æhp‚ğ—^‚¦‚ÄŒÄ‚Ô
        Check(checker, hp);
    }

    //‘O‚Ì–â‘è‚Åì‚Á‚½Aint‚ğˆø”‚Æ‚µ‚Äbool‚ğ•Ô‚·ŠÖ”
    bool CanDefeatBoss(int hp) {
        if(hp >= 10000) {
            return true;
        } else {
            return false;
        }
    }
    bool CanDefeatZako(int hp) {
        if(hp >= 100) {
            return true;
        } else {
            return false;
        }
    }
}
