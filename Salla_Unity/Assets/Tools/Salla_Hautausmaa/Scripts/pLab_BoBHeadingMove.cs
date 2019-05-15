/******************************************************************************
* File         : pLab_BoBHeadingMove.cs
* Authors      : Toni Westerlund (toni.westerlund@lapinamk.fi),
* Lisence      : MIT Licence
* Copyright    : Lapland University of Applied Sciences
* 
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

/// <summary>
/// TODO: Fast Prototype
/// </summary>
public class pLab_BoBHeadingMove : MonoBehaviour
{

    #region // SerializeField
    #endregion

    #region // Private Attributes

    /// <summary>
    /// 
    /// </summary>
    private float timer;

    /// <summary>
    /// 
    /// </summary>
    private float bobbingSpeed = 0.15f;

    /// <summary>
    /// 
    /// </summary>
    private float bobbingAmount = 0.01f;

    /// <summary>
    /// 
    /// </summary>
    private float translateChange = 0f;

    /// <summary>
    /// 
    /// </summary>
    private float totalAxes;

    /// <summary>
    /// 
    /// </summary>
    private float midpoint = 0f;


    #endregion

    #region // Class Attributes

    #endregion

    #region // Public Attributes

    /// <summary>
    /// 
    /// </summary>
    public bool headBOB = false;

    #endregion

    #region // Protected Attributes

    #endregion

    #region // Set/Get

    #endregion

    #region // Base Class Methods

    /// <summary>
    /// 
    /// </summary>
    void Update() {
        if (headBOB) {
            float waveslice = 0f;
            waveslice = Mathf.Sin(timer);
            timer = timer + bobbingSpeed;

            if (timer > Mathf.PI * 2) {
                timer = timer - (Mathf.PI * 2);
            }

            if (waveslice != 0) {
                translateChange = waveslice * bobbingAmount;
                totalAxes = Mathf.Abs(1) + Mathf.Abs(1);
                totalAxes = Mathf.Clamp(totalAxes, 0.0f, 1.0f);
                translateChange = totalAxes * translateChange;
                Vector3 tmpPos = transform.localPosition;
                tmpPos.y = midpoint + translateChange;
                transform.localPosition = tmpPos;
            }
        }
    }
    #endregion

    #region // Private Methods
    #endregion

    #region // Public Methods

    /// <summary>
    /// StartAnimation
    /// </summary>
    public void StartAnimation() {
        headBOB = true;
        GetComponent<Animator>().Play("HeadAnimation");
    }

    /// <summary>
    /// StopAnimation
    /// </summary>
    public void StopAnimation() {
        headBOB = false;
        GetComponent<Animator>().Play("empty");
    }

    #endregion




}
