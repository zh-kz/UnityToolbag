﻿/*
 * Copyright (c) 2014, Nick Gravelyn.
 *
 * This software is provided 'as-is', without any express or implied
 * warranty. In no event will the authors be held liable for any damages
 * arising from the use of this software.
 *
 * Permission is granted to anyone to use this software for any purpose,
 * including commercial applications, and to alter it and redistribute it
 * freely, subject to the following restrictions:
 *
 *    1. The origin of this software must not be misrepresented; you must not
 *    claim that you wrote the original software. If you use this software
 *    in a product, an acknowledgment in the product documentation would be
 *    appreciated but is not required.
 *
 *    2. Altered source versions must be plainly marked as such, and must not be
 *    misrepresented as being the original software.
 *
 *    3. This notice may not be removed or altered from any source
 *    distribution.
 */

using UnityEngine;
using UnityEditor;

namespace UnityToolbag {
    [CustomPropertyDrawer(typeof(SortingLayerAttribute))]
    public class SortingLayerDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            var sortingLayerNames = SortingLayerHelper.sortingLayerNames;
            if (sortingLayerNames != null) {
                EditorGUI.BeginProperty(position, label, property);
                int newLayerIndex = EditorGUI.Popup(position, label.text, property.intValue, sortingLayerNames);
                if (newLayerIndex != property.intValue) {
                    property.intValue = newLayerIndex;
                }
                EditorGUI.EndProperty();
            }
            else {
                base.OnGUI(position, property, label);
            }
        }
    }
}
