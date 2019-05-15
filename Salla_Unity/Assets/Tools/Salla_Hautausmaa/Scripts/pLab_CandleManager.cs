/******************************************************************************
* File         : pLab_CandleManager.cs
* Authors      : Toni Westerlund (toni.westerlund@lapinamk.fi),
* Lisence      : MIT Licence
* Copyright    : Lapland University of Applied Sciences
* Version      : Fast Prototype
* MIT License
* 
* Copyright (c) 2019 Lapland University of Applied Sciences
* 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
* of this software and associated documentation files (the "Software"), to deal
* in the Software without restriction, including without limitation the rights
* to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
* copies of the Software, and to permit persons to whom the Software is
* furnished to do so, subject to the following conditions:
* 
 * The above copyright notice and this permission notice shall be included in all
* copies or substantial portions of the Software.
* 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
* IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
* FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
* AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
* LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
* OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
* SOFTWARE.
*****************************************************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

/// <summary>
/// 
/// </summary>
[Serializable]
public class Candledata {
    public List<Positions> item;
}

/// <summary>
/// 
/// </summary>
[Serializable]
public class Positions {
    public float posx;
    public float posy;
    public float posz;
    public float rotx;
    public float roty;
    public float rotz;
}


/// <summary>
/// 
/// </summary>
public class pLab_CandleManager : MonoBehaviour
{

    #region // SerializeField
    #endregion

    #region // Private Attributes

    /// <summary>
    /// 
    /// </summary>
    private string path;

    #endregion

    #region // Class Attributes

    #endregion

    #region // Public Attributes

    /// <summary>
    /// 
    /// </summary>
    public static pLab_CandleManager instance = null;

    /// <summary>
    /// 
    /// </summary>
    public Candledata candleData;

    /// <summary>
    /// 
    /// </summary>
    public GameObject tmpCandle;

    /// <summary>
    /// 
    /// </summary>
    public GameObject tmpCandlePos;

    /// <summary>
    /// 
    /// </summary>
    public GameObject sceneCandle;

    #endregion

    #region // Protected Attributes

    #endregion

    #region // Set/Get

    #endregion

    #region // Base Class Methods


    /// <summary>
    /// 
    /// </summary>
    void Awake() {

        if (instance == null) instance = this;

    }

    /// <summary>
    /// 
    /// </summary>
    void Start() {
        path = Application.persistentDataPath + "/saveData";
        LoadCabdles(path);


        foreach (Positions tmpPos in candleData.item) {
            Vector3 vectorPos = tmpCandlePos.gameObject.transform.position;
            GameObject.Instantiate(tmpCandle, vectorPos, Quaternion.identity).SetActive(true);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    void OnApplicationQuit() {

        if (sceneCandle == null)
            return;

        if (sceneCandle.GetComponent<Rigidbody>().isKinematic == true)
            return;

        Positions pos = new Positions();
        pos.posx = sceneCandle.transform.position.x;
        pos.posy = sceneCandle.transform.position.y;
        pos.posz = sceneCandle.transform.position.z;
        pos.rotx = sceneCandle.transform.eulerAngles.x;
        pos.roty = sceneCandle.transform.eulerAngles.y;
        pos.rotz = sceneCandle.transform.eulerAngles.z;

        candleData.item.Add(pos);
        SaveCandles(path);
    }

    #endregion

    #region // Private Methods
    #endregion

    #region // Public Methods

    /// <summary>
    /// SaveCandles
    /// </summary>
    /// <param name="path"></param>
    public void SaveCandles(string path) {
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        using (FileStream fileStream = File.Open(path, FileMode.OpenOrCreate)) {
            binaryFormatter.Serialize(fileStream, candleData);
        }
    }

    /// <summary>
    /// LoadCabdles
    /// </summary>
    /// <param name="path"></param>
    public void LoadCabdles(string path) {

        if (File.Exists(path)) {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = File.Open(path, FileMode.Open)) {
                candleData = (Candledata)binaryFormatter.Deserialize(fileStream);
            }
        }
        SaveCandles(path);
    }

    #endregion


}
