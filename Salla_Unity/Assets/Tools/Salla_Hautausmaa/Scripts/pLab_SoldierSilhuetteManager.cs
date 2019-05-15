/******************************************************************************
* File         : pLab_SoldierSilhuetteManager.cs
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
public class pLab_SoldierSilhuetteManager : MonoBehaviour{



    #region // SerializeField
    #endregion

    #region // Private Attributes


    #endregion

    #region // Class Attributes

    #endregion

    #region // Public Attributes

    /// <summary>
    /// 
    /// </summary>
    public static pLab_SoldierSilhuetteManager instance = null;

    /// <summary>
    /// 
    /// </summary>
    public GameObject soldierSilhuette;

    /// <summary>
    /// 
    /// </summary>
    public GameObject soldierSilhuettes;

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

        float startx = -55f;
        float startz = -100f;
        for (int i = 0; i < 25; i++) {
            for (int ia = 0; ia < 75; ia++) {

                Vector3 tmpPos = new Vector3(startx + i * 2f, 0, startz + ia * 2f);

                GameObject.Instantiate(soldierSilhuette, tmpPos, Quaternion.identity, soldierSilhuettes.transform);
            }
        }
        startx = 5f;
        startz = -100f;

        for (int i = 0; i < 25; i++) {
            for (int ia = 0; ia < 75; ia++) {

                Vector3 tmpPos = new Vector3(startx + i * 2f, 0, startz + ia * 2f);

                GameObject.Instantiate(soldierSilhuette, tmpPos, Quaternion.identity, soldierSilhuettes.transform);
            }
        }
    }

    #endregion

    #region // Private Methods
    #endregion

    #region // Public Methods

    #endregion




}
