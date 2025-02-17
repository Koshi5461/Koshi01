/******************************************************************************
 * Copyright (C) Leap Motion, Inc. 2011-2017.                                 *
 * Leap Motion proprietary and  confidential.                                 *
 *                                                                            *
 * Use subject to the terms of the Leap Motion SDK Agreement available at     *
 * https://developer.leapmotion.com/sdk_agreement, or another agreement       *
 * between Leap Motion and you, your company or other organization.           *
 ******************************************************************************/

using System;

namespace Leap.Unity.GraphicalRenderer {

  [LeapGraphicTag("Custom Channel/Vector", 120)]
  [Serializable]
  public class CustomVectorChannelFeature : CustomChannelFeatureBase<CustomVectorChannelData> { }
}
