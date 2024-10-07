using MinimalApi.Dominio.Entidades;

namespace Test.Dimain.Entidades;

[TestClass]
public class VeiculosTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        var veiculo = new Veiculo
        {
            Id = 1,
            Nome = "HB20",
            Marca = "Hyundai",
            Ano = 1960,
        };

        Assert.AreEqual(1, veiculo.Id);
        Assert.AreEqual("HB20", veiculo.Nome);
        Assert.AreEqual("Hyundai", veiculo.Marca);
        Assert.AreEqual(1960, veiculo.Ano);
    }
}