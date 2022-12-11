namespace Chubrik.Json.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;
using static Chubrik.Json.Tests.Constants;

[TestClass]
public sealed class Tests
{
    [TestMethod]
    public void KebabLowerSerialize()
    {
        var json = JsonSerializer.Serialize(TestObject, KebabLowerCaseJsonOptions);
        Assert.AreEqual(KebabLowerJson, json);
    }

    [TestMethod]
    public void KebabLowerDeserialize()
    {
        var deserialized = JsonSerializer.Deserialize<Serializable>(KebabLowerJson, KebabLowerCaseJsonOptions);
        Assert.IsNotNull(deserialized);
        AssertDeserialized(deserialized);
    }

    [TestMethod]
    public void KebabUpperSerialize()
    {
        var json = JsonSerializer.Serialize(TestObject, KebabUpperCaseJsonOptions);
        Assert.AreEqual(KebabUpperJson, json);
    }

    [TestMethod]
    public void KebabUpperDeserialize()
    {
        var deserialized = JsonSerializer.Deserialize<Serializable>(KebabUpperJson, KebabUpperCaseJsonOptions);
        Assert.IsNotNull(deserialized);
        AssertDeserialized(deserialized);
    }

    [TestMethod]
    public void SnakeLowerSerialize()
    {
        var json = JsonSerializer.Serialize(TestObject, SnakeLowerCaseJsonOptions);
        Assert.AreEqual(SnakeLowerJson, json);
    }

    [TestMethod]
    public void SnakeLowerDeserialize()
    {
        var deserialized = JsonSerializer.Deserialize<Serializable>(SnakeLowerJson, SnakeLowerCaseJsonOptions);
        Assert.IsNotNull(deserialized);
        AssertDeserialized(deserialized);
    }

    [TestMethod]
    public void SnakeUpperSerialize()
    {
        var json = JsonSerializer.Serialize(TestObject, SnakeUpperCaseJsonOptions);
        Assert.AreEqual(SnakeUpperJson, json);
    }

    [TestMethod]
    public void SnakeUpperDeserialize()
    {
        var deserialized = JsonSerializer.Deserialize<Serializable>(SnakeUpperJson, SnakeUpperCaseJsonOptions);
        Assert.IsNotNull(deserialized);
        AssertDeserialized(deserialized);
    }

    private static void AssertDeserialized(Serializable deserialized)
    {
        Assert.AreEqual(TestObject.Prop, deserialized.Prop);
        Assert.AreEqual(TestObject.UPPER, deserialized.UPPER);
        Assert.AreEqual(TestObject.lower, deserialized.lower);
        Assert.AreEqual(TestObject.PascalProp, deserialized.PascalProp);
        Assert.AreEqual(TestObject.camelProp, deserialized.camelProp);
        Assert.AreEqual(TestObject.Snake_Prop, deserialized.Snake_Prop);
        Assert.AreEqual(TestObject.SNAKE_UPPER, deserialized.SNAKE_UPPER);
        Assert.AreEqual(TestObject.snake_lower, deserialized.snake_lower);
        Assert.AreEqual(TestObject.Snake__Long, deserialized.Snake__Long);
        Assert.AreEqual(TestObject.SEMIUpper, deserialized.SEMIUpper);
        Assert.AreEqual(TestObject._Underlined_, deserialized._Underlined_);
        Assert.AreEqual(TestObject.__MoreLines__, deserialized.__MoreLines__);
        Assert.AreEqual(TestObject.Version1, deserialized.Version1);
        Assert.AreEqual(TestObject.Version1_0, deserialized.Version1_0);
        Assert.AreEqual(TestObject.Version1__1, deserialized.Version1__1);
        Assert.AreEqual(TestObject.Version_1_2, deserialized.Version_1_2);
        Assert.AreEqual(TestObject.Version__1_3, deserialized.Version__1_3);
        Assert.AreEqual(TestObject.Version2Alpha, deserialized.Version2Alpha);
        Assert.AreEqual(TestObject.Version3beta, deserialized.Version3beta);
        Assert.AreEqual(TestObject.Version4_Gamma, deserialized.Version4_Gamma);
        Assert.AreEqual(TestObject.Version5_delta, deserialized.Version5_delta);
        Assert.AreEqual(TestObject.Version6__Zeta, deserialized.Version6__Zeta);
        Assert.AreEqual(TestObject.Version7__eta, deserialized.Version7__eta);
        Assert.AreEqual(TestObject.Hex1_0xa1b23c, deserialized.Hex1_0xa1b23c);
        Assert.AreEqual(TestObject.Hex2_0xA1B23C, deserialized.Hex2_0xA1B23C);
        Assert.AreEqual(TestObject.ЮникодПроп, deserialized.ЮникодПроп);
    }
}
