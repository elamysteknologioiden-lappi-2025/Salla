/******************************************************************************
* File         : pLab_VRTKControllerEvents.cs
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

    public class pLab_VRTKControllerEvents : MonoBehaviour {

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
        public pLab_BoBHeadingMove bobHeading;

        #endregion

        #region // Protected Attributes

        #endregion

        #region // Set/Get

        #endregion

        #region // Base Class Methods

        /// <summary>
        /// 
        /// </summary>
        void OnEnable() {
            GetComponent<VRTK_ControllerEvents>().ButtonOnePressed += new ControllerInteractionEventHandler(DoButtonOnePressed);
            GetComponent<VRTK_ControllerEvents>().ButtonOneReleased += new ControllerInteractionEventHandler(DoButtonOneReleased);
        }

        /// <summary>
        /// 
        /// </summary>
        void OnDisable() {
            GetComponent<VRTK_ControllerEvents>().ButtonOnePressed -= new ControllerInteractionEventHandler(DoButtonOnePressed);
            GetComponent<VRTK_ControllerEvents>().ButtonOneReleased -= new ControllerInteractionEventHandler(DoButtonOneReleased);
        }

        #endregion

        #region // Private Methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoButtonOnePressed(object sender, ControllerInteractionEventArgs e) {
            bobHeading.StartAnimation();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DoButtonOneReleased(object sender, ControllerInteractionEventArgs e) {
            bobHeading.StopAnimation();
        }

        #endregion

        #region // Public Methods

        #endregion






    }
}
