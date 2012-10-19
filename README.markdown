# Explanations

Instrument your code with explanations so it's not a mysterious black box, but one that explains what it does.

## Usage

Use the static `Explain` class to instrument your code:

    var properties
        = from p in candidateType.GetProperties()
          where HasDescription(p);
    Explain.Step("Found {0} candidate properties", properties.Count());

    if (property.PropertyType() != typeof(bool))
    {
        Explain.Decision("Property {0} is not of type bool", property.Name);
        return null;
    }

To collect all the individual messages together into a single explanation, wrap use of the instrumented code in an ambient Explanation:

    using (var e = new Explanation())
    {
        // Anything explained here will be collected in the explanation
    }
    
The messages can be accessed anywhere by inspecting the `Details` property or collected at a point in time by creating an instance of `Explainable<T>`.

