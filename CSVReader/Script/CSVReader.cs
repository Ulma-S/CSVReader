using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class CSVReader : MonoBehaviour
{
    [SerializeField] private string m_fileName; //csvファイル名
    private TextAsset m_csvFile;
    private List<string[]> m_csvDatas = new List<string[]>();

    private void Start()
    {
        m_csvFile = Resources.Load(m_fileName) as TextAsset;    

        StringReader reader = new StringReader(m_csvFile.text); //テキストストリーム

        while (reader.Peek() != -1)
        {
            string line = reader.ReadLine();
            m_csvDatas.Add(line.Split(','));
        }

        for(int i = 0; i<m_csvDatas.Count; i++)
        {
            for(int j = 0; j < m_csvDatas[i].Length; j++)
            {
                print("["+ i + "]" + "[" + j + "]" + m_csvDatas[i][j]);
            }
        }
    }
}
