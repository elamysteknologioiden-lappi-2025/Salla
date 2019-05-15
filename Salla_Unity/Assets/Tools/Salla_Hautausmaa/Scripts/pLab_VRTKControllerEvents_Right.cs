/******************************************************************************
* File         : pLab_VRTKControllerEvents_Right.cs
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


namespace VRTK.Examples {
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    public class pLab_VRTKControllerEvents_Right : MonoBehaviour {



        #region // SerializeField

        /// <summary>
        /// 
        /// </summary>
        [SerializeField]
        private GameObject candle;

        /// <summary>
        /// 
        /// </summary>
        [SerializeField]
        private GameObject localAvatar;


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
        /// 
        /// </summary>
        void Start() {
            GetComponent<VRTK_ControllerEvents>().ButtonOnePressed += new ControllerInteractionEventHandler(DoButtonOnePressed);
        }

        #endregion

        #region // Private Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoButtonOnePressed(object sender, ControllerInteractionEventArgs e) {
            if (pLab_CandleManager.instance.sceneCandle != null)
                Destroy(pLab_CandleManager.instance.sceneCandle);

            pLab_CandleManager.instance.sceneCandle = GameObject.Instantiate(candle, localAvatar.transform.position, Quaternion.identity);
            pLab_CandleManager.instance.sceneCandle.SetActive(true);
        }


        #endregion

        #region // Public Methods

        #endregion


    }
}
