/******************************************************************************
* File         : pLab_SallaLogic.cs
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
using VRTK;
using VRTK.Examples;

/// <summary>
/// pLab_SallaLogic
/// </summary>
public class pLab_SallaLogic : MonoBehaviour{

    #region // SerializeField

    /// <summary>
    /// startPoint
    /// </summary>
    [SerializeField] private GameObject startPoint;


    [SerializeField] private GameObject ovrCameraRig;

    /// <summary>
    /// vrCharacter
    /// </summary>
    [SerializeField] private GameObject vrCharacter;

    /// <summary>
    /// localAvarar
    /// </summary>
    [SerializeField] private GameObject localAvarar;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] private pLab_VRTKControllerEvents customEvent;

    /// <summary>
    /// pLab_BoBHeadingMove
    /// </summary>
    [SerializeField] private pLab_BoBHeadingMove bobHeading;

    /// <summary>
    /// VRTK_ControllerUIPointerEvents_ListenerExample
    /// </summary>
    [SerializeField] private VRTK_StraightPointerRenderer vRTK_StraightPointerRenderer;

    /// <summary>
    /// VRTK_Pointer
    /// </summary>
    [SerializeField] private VRTK_Pointer vRTK_Pointer;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] private GameObject showSilButton;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] private GameObject hideSilButton;

    /// <summary>
    /// 
    /// </summary>
    [SerializeField] private GameObject silhouettes;

    #endregion

    #region // Private Attributes


    #endregion

    #region // Class Attributes

    #endregion

    #region // Public Attributes



    #endregion

    #region // Protected Attributes

    #endregion

    #region // Set/Get

    #endregion

    #region // Base Class Methods

    /// <summary>
    /// Start()
    /// </summary>
    private void Start() {

        InvokeRepeating("CheckFreePosition", 0, 0.2f);
    }


    #endregion

    #region // Private Methods

    /// <summary>
    /// 
    /// </summary>
    private void CheckFreePosition() {

        if (localAvarar.transform.position.z > 50f) {
            vRTK_StraightPointerRenderer.enabled = true;
            vRTK_Pointer.enabled = true;

            bobHeading.StopAnimation();
            customEvent.enabled = false;
            CancelInvoke("CheckFreePosition");
        }
    }

    #endregion

    #region // Public Methods

    /// <summary>
    /// 
    /// </summary>
    public void SetActionZone() {
        Debug.LogError("SetActionZone");
        Vector3 tmpPosition = ovrCameraRig.transform.position;
        tmpPosition.z = 50f;
        ovrCameraRig.transform.position = tmpPosition;

        vRTK_StraightPointerRenderer.enabled = true;
        vRTK_Pointer.enabled = true;

        bobHeading.StopAnimation();
        customEvent.enabled = false;
        CancelInvoke("CheckFreePosition");
    }

    /// <summary>
    /// 
    /// </summary>
    public void ShowSilhouette() {
        silhouettes.SetActive(true);
        showSilButton.SetActive(false);
        hideSilButton.SetActive(true);
    }

    /// <summary>
    /// 
    /// </summary>
    public void HideSilhouette() {
        silhouettes.SetActive(false);
        showSilButton.SetActive(true);
        hideSilButton.SetActive(false);
    }

    #endregion

}
