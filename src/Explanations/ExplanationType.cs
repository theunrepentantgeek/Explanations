using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explanations
{
    public enum ExplanationType
    {
        None,

        /// <summary>
        /// Explanation records an operation step 
        /// </summary>
        Step,

        /// <summary>
        /// Explanation records a decision made during an operation
        /// </summary>
        Decision,

        /// <summary>
        /// Explanation records a failed operation
        /// </summary>
        Failure,

        /// <summary>
        /// Explanation records a successful operation
        /// </summary>
        Success
    }
}
