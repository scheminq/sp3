namespace Projeto_Web_Lh_Pets_versão_1
{
class Clientes
{
        private string nome1;

        public string? cpf_cnpj {get; set;}
        public string nome { get => nome1; set => nome1 = value; }

        public Clientes(string nome)
        {
            this.nome = nome;
        }
        public string endereco {get; set;}
    public string rg_ie {get; set;}
    public string tipo {get; set;}
    public float valor {get; set;}
    public float valor_imposto {get; set;}
    public float total {get; set;}
    }
}
