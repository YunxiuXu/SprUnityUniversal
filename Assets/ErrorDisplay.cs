using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ErrorDisplay : MonoBehaviour
{
    internal void OnEnable()
    {
        //Application.RegisterLogCallback(HandleLog); //已弃用
        Application.logMessageReceived += HandleLog;
    }
    internal void OnDisable()
    {
        //Application.RegisterLogCallback(null);//已弃用
        Application.logMessageReceived -= HandleLog;
    }
    private string logs;
    /// <summary>
    ///
    /// </summary>
    /// <param name="logString">错误信息</param>
    /// <param name="stackTrace">跟踪堆栈bai</param>
    /// <param name="type">错误类型</param>
    void HandleLog(string logString, string stackTrace, LogType type)
    {
        logs += logString + "\n";
        errMsg.text = logs;
    }
    public Text errMsg;
    public bool Log;
    //private Vector2 scroll;
    //internal void OnGUI()
    //{
    //    if (!Log)
    //        return;
    //    scroll = GUILayout.BeginScrollView(scroll);
    //    GUILayout.Label(m_logs);
    //    GUILayout.EndScrollView();
    //}
}

