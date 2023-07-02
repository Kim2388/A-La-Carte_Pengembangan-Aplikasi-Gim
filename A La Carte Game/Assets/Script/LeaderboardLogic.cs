using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeaderboardLogic : MonoBehaviour
{
    public List<TextMeshProUGUI> Text;
    public List<int> score;
    public int ScoreUser;
    // Start is called before the first frame update
    void Start()
    {
       for(int i = 0; i < Text.Count; i++) {
            Text[i].text = score[i].ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(ScoreUser != 0) {
            score.Add(ScoreUser);
            score.Sort();
            score.Reverse();
            score.RemoveRange(3, 1);
            for (int i = 0; i < Text.Count; i++)
            {
                Text[i].text = score[i].ToString();
            }
            ScoreUser = 0;
        }

    }
}
