using System;

using R5T.T0131;
using R5T.T0224;
using R5T.T0224.Extensions;


namespace D8S.Z0008
{
    [ValuesMarker]
    public partial interface ILinks : IValuesMarker
    {
        /// <summary>
        /// Cartoon showing that in the past, do things used to involve special equipment. Now it just involves sitting at a laptop.
        /// Source: http://www.ebaumsworld.com/pictures/z-u-r-d-zombie-unicorn-random-day-5/81594179/
        /// Similar: https://pc-freak.net/blog/then-and-now/
        /// </summary>
        /// <remarks>
        /// File: C:\Users\David\Dropbox\Organizations\David\Documents\Blogs\ΩImages\Then-and-now.jpg
        /// </remarks>
        public IUrl EverythingIsOnAComputerNow => @"https://cdn.ebaumsworld.com/mediaFiles/picture/1000187/81594180.jpg".ToUrl();
    }
}
