﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cutscene_03 : MonoBehaviour {

    public GameObject Teacher;
    public GameObject AJ;

    Animator teacher_anim;
    Animator aj_anim;

    public GameObject[] Dialogues;
    public GameObject touch_skip_btn;

    public GameObject ID_Panel;

    public int x;

	void Start ()
    {
        teacher_anim = Teacher.GetComponent<Animator>();
        aj_anim = AJ.GetComponent<Animator>();

        teacher_anim.SetInteger("dialogue_is", x % 2);
        aj_anim.SetInteger("dialogue_is", x % 2);

        touch_skip_btn.active = true;

        for (int i = 1; i<Dialogues.Length; i++)
        {
            Dialogues[i].active = false;
        }
    }

    public void Change_Cutscene()
    {
        teacher_anim.SetInteger("dialogue_is", x % 2);
        aj_anim.SetInteger("dialogue_is", x % 2);

        if (x >= 6)
        {
            ID_Panel.active = true;
            Dialogues[6].active = false;
            touch_skip_btn.active = false;
            return;
        }
        Dialogues[x].active = false;
        Dialogues[x+1].active = true;
        x++;
    }

    public void Next_Level(string scene_name)
    {
        Application.LoadLevel(scene_name);
    }
}
