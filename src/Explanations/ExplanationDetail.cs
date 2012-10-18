using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explanations
{
    public class ExplanationDetail
    {
        /// <summary>
        /// Gets the kind of detail
        /// </summary>
        public ExplanationType Kind { get; private set; }

        /// <summary>
        /// Gets the message associated with this detail
        /// </summary>
        public string Message { get; private set; }

        /// <summary>
        /// Initializes a new instance of the ExplanationDetail class
        /// </summary>
        /// <param name="kind">Kind of detail</param>
        /// <param name="message">Message for this detail</param>
        public ExplanationDetail(ExplanationType kind, string message)
        {
            Kind = kind;
            Message = message;
        }
    }
}
