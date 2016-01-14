﻿namespace MyTested.Mvc.Builders.Actions.ShouldReturn
{
    using Microsoft.AspNet.Mvc;
    using Contracts.Base;

    /// <summary>
    /// Class containing methods for testing NoContentResult.
    /// </summary>
    /// <typeparam name="TActionResult">Result from invoked action in ASP.NET MVC 6 controller.</typeparam>
    public partial class ShouldReturnTestBuilder<TActionResult>
    {
        /// <summary>
        /// Tests whether action result is NoContentResult.
        /// </summary>
        /// <returns>Base test builder with action result.</returns>
        public IBaseTestBuilderWithActionResult<TActionResult> NoContent()
        {
            this.GetReturnObject<NoContentResult>();
            return this.NewAndProvideTestBuilder();
        }
    }
}