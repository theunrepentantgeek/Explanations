using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explanations
{
    public static class Explain
    {
        /// <summary>
        /// Explain a successful operation
        /// </summary>
        /// <param name="template">Provide a template for the message.</param>
        /// <param name="parameters">Parameters to use to fill in the template.</param>
        public static void Success(string template, params object[] parameters)
        {
            AddExplanation(ExplanationType.Success, template, parameters);
        }

        /// <summary>
        /// Explain a failed operation
        /// </summary>
        /// <param name="template">Provide a template for the message.</param>
        /// <param name="parameters">Parameters to use to fill in the template.</param>
        public static void Failure(string template, params object[] parameters)
        {
            AddExplanation(ExplanationType.Failure, template, parameters);
        }

        /// <summary>
        /// Explain a successful operation
        /// </summary>
        /// <param name="template">Provide a template for the message.</param>
        /// <param name="parameters">Parameters to use to fill in the template.</param>
        public static void Decision(string template, params object[] parameters)
        {
            AddExplanation(ExplanationType.Decision, template, parameters);
        }

        /// <summary>
        /// Explain a successful operation
        /// </summary>
        /// <param name="template">Provide a template for the message.</param>
        /// <param name="parameters">Parameters to use to fill in the template.</param>
        public static void Step(string template, params object[] parameters)
        {
            AddExplanation(ExplanationType.Step, template, parameters);
        }

        /// <summary>
        /// Explain any operation
        /// </summary>
        /// <param name="kind">Kind of explanation</param>
        /// <param name="template">Provide a template for the message.</param>
        /// <param name="parameters">Parameters to use to fill in the template.</param>
        private static void AddExplanation(ExplanationType kind, string template, params object[] parameters)
        {
            var explanation = Explanation.Current;
            if (explanation != null)
            {
                explanation.Explain(kind, template, parameters);
            }
        }
    }
}
