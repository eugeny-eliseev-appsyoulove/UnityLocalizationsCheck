using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;
using UnityEngine.Profiling;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class Test : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    [SerializeField] private Button _button;

    [SerializeField] private TMP_Text _text;
    
    void Start()
    {
        // Application.targetFrameRate = 30;
        
        // _button.onClick.AddListener(() =>
        // {
        //     Profiler.BeginSample("Localization");
        //     var unused = 
        //     Profiler.EndSample();
        // });
        
        // var x = LocalizationSettings.StringDatabase.GetLocalizedString("Mmmm", "X");
        // Debug.LogWarning(x);
    }

    // Update is called once per frame
    void Update()
    {
        var startNew = Stopwatch.StartNew();
        F1();
        var x1 = startNew.ElapsedMilliseconds;
        F2();
        var x2 = startNew.ElapsedMilliseconds;
        Debug.LogWarning($"RVRM {x1} {x2-x1}");
    }

    void F1()
    {
        _text.text = LocalizationSettings.StringDatabase.GetLocalizedString("Mmmm", "X");
    }

    void F2()
    {
        _text.text = LocalizationSettings.StringDatabase.GetLocalizedString("Mmmm", "X");
    }
}
