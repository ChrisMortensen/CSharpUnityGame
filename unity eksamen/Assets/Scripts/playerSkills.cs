using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class playerSkills
{

    private characterManager charMan;
    public void updateSkills(string name)
    {
        switch (name)
        {
            case "warrior":
                charMan.bonusStat("abilityHaste",1);
                break;
            case "warrior1":
                charMan.bonusStat("abilityHaste",1);
                break;
            case "warrior2":
				charMan.bonusPercentage("agility",50);
                break;
            case "warrior3":
				charMan.bonusPercentage("strength",50);
                break;   
            case "wizard":
				charMan.bonusStat("abilityHaste",1);
                break;
            case "wizard1":
                charMan.bonusStat("agility",5);
                break;
            case "wizard2":
                charMan.bonusStat("agility",5);
                break;
            case "wizard3":
                charMan.bonusStat("agility",5);
                break;
            case "orb":
				Debug.Log("Updated orb ");
                break;
            case "orb1":
				Debug.Log("Updated orb 1");
                break;
            case "orb2":
				Debug.Log("Updated orb 2");
                break;
            case "orb3":
				Debug.Log("Updated orb 3");
                break;
            default:
                return;
        }
    }

    public void setCharMan(characterManager characterManager){
        charMan=characterManager;
    }
}
