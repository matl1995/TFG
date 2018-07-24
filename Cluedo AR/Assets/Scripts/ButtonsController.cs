using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsController : MonoBehaviour {

	static private int num_select;

    private Button PlayButton;

	private Toggle Toggle1;
	private Toggle Toggle2;
	private Toggle Toggle3;
	private Toggle Toggle4;
	private Toggle Toggle5;
	private Toggle Toggle6;

	static public string Character1;
	static public string Character2;


	// Use this for initialization
	void Start () {
        Screen.sleepTimeout=SleepTimeout.NeverSleep;
		num_select=0;

        Character1=null;
        Character2=null;

        PlayButton=GameObject.Find("PlayButton").GetComponent<Button>();

		Toggle1=GameObject.Find("Toggle1").GetComponent<Toggle>();
		Toggle2=GameObject.Find("Toggle2").GetComponent<Toggle>();
		Toggle3=GameObject.Find("Toggle3").GetComponent<Toggle>();
		Toggle4=GameObject.Find("Toggle4").GetComponent<Toggle>();
		Toggle5=GameObject.Find("Toggle5").GetComponent<Toggle>();
		Toggle6=GameObject.Find("Toggle6").GetComponent<Toggle>();

		Toggle1.onValueChanged.AddListener(delegate {
                ToggleValueChanged(Toggle1);
            });

		Toggle2.onValueChanged.AddListener(delegate {
                ToggleValueChanged(Toggle2);
            });

		Toggle3.onValueChanged.AddListener(delegate {
                ToggleValueChanged(Toggle3);
            });

		Toggle4.onValueChanged.AddListener(delegate {
                ToggleValueChanged(Toggle4);
            });

		Toggle5.onValueChanged.AddListener(delegate {
                ToggleValueChanged(Toggle5);
            });

		Toggle6.onValueChanged.AddListener(delegate {
                ToggleValueChanged(Toggle6);
            });
	}
	
	// Update is called once per frame
	void Update () {
	}

	void ToggleValueChanged(Toggle change)
    {
    	if(change.isOn)
    	{
    		if(Character1==null)
    		{
    			Character1=change.name;
    		}
    		else
    		{
    			Character2=change.name;
    		}

    		num_select++;

    		if(num_select==2)
    		{
    			if(!Toggle1.name.Equals(Character1) && !Toggle1.name.Equals(Character2))
    			{
    				Toggle1.enabled=false;
    			}

    			if(!Toggle2.name.Equals(Character1) && !Toggle2.name.Equals(Character2))
    			{
    				Toggle2.enabled=false;
    			}

    			if(!Toggle3.name.Equals(Character1) && !Toggle3.name.Equals(Character2))
    			{
    				Toggle3.enabled=false;
    			}

    			if(!Toggle4.name.Equals(Character1) && !Toggle4.name.Equals(Character2))
    			{
    				Toggle4.enabled=false;
    			}

    			if(!Toggle5.name.Equals(Character1) && !Toggle5.name.Equals(Character2))
    			{
    				Toggle5.enabled=false;
    			}

    			if(!Toggle6.name.Equals(Character1) && !Toggle6.name.Equals(Character2))
    			{
    				Toggle6.enabled=false;
    			}

                PlayButton.interactable=true;
    		}
    	}
    	else
    	{
    		if(Character1!=null && Character1.Equals(change.name))
    		{
    			Character1=null;
    		}
    		else
    		{
    			Character2=null;
    		}

    		num_select--;

    		if(!Toggle1.name.Equals(Character1) && !Toggle1.name.Equals(Character2))
			{
				Toggle1.enabled=true;
			}

			if(!Toggle2.name.Equals(Character1) && !Toggle2.name.Equals(Character2))
			{
				Toggle2.enabled=true;
			}

			if(!Toggle3.name.Equals(Character1) && !Toggle3.name.Equals(Character2))
			{
				Toggle3.enabled=true;
			}

			if(!Toggle4.name.Equals(Character1) && !Toggle4.name.Equals(Character2))
			{
				Toggle4.enabled=true;
			}

			if(!Toggle5.name.Equals(Character1) && !Toggle5.name.Equals(Character2))
			{
				Toggle5.enabled=true;
			}

			if(!Toggle6.name.Equals(Character1) && !Toggle6.name.Equals(Character2))
			{
				Toggle6.enabled=true;
			}

            PlayButton.interactable=false;
    	}
    }
}
