



using System;

namespace Employees
{
    public class Employee
    {
        // Campos de dados.
        // Não são propriedades!!!
        #region Campos (pontos) de dados
        private string _empName;
        private int _empId;
        private float _currPay;
        private int _empAge;
        private EmployeePayTypeEnum _payType;
        #endregion

        // Encapsulando dados utilizando propriedades.
        #region Propriedades
        public string Name
        {
            get { return _empName; }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Erro!\nO nome do empregado tem mais de 15 caracteres!");
                }
                else
                {
                    _empName = value;
                }
            }
        }

        public int Id
        {
            get { return _empId; }
            set { _empId = value; }
        }

        public float Pay
        {
            get { return _currPay; }
            set { _currPay = value; }
        }

        public int Age
        {
            get => _empAge;
            set => _empAge = value;
        }

        public EmployeePayTypeEnum PayType
        {
            get => _payType;
            set => _payType = value;
        }
        #endregion

        // Construtores dos objetos.
        #region Construtores
        public Employee() { }
        public Employee(string name, int id, float pay) :this(name, 0, id, pay, EmployeePayTypeEnum.Salaried) { }
        public Employee(string name, int age, int id, float pay, EmployeePayTypeEnum payType)
        {
            Name = name;
            Age = age;
            Id = id;
            Pay = pay;
            PayType = payType;
        }
        #endregion

        // Método do tipo GET (para acessar o valor da campo _empName)
        #region Métodos Acessores/Mutadores
        public string GetName()
            => _empName;

        // Método do tipo SET (para alterar o valor do campo _empName)
        public void SetName(string name)
        {
            if (name.Length > 15)
            {
                Console.WriteLine("Erro!\nO nome tem um tamanho superior a 15 caracteres!");
            }
            else
            {
                _empName = name;
            }
        }
        #endregion

        // Métodos
        #region Métodos comuns
        public void GiveBonus(float amount)
        {
            Pay = this switch
            {
                { PayType: EmployeePayTypeEnum.Commision }
                    => Pay += .10F * amount,
                { PayType: EmployeePayTypeEnum.Hourly }
                    => Pay += 40F * amount / 2080F,
                { PayType: EmployeePayTypeEnum.Salaried }
                    => Pay += amount,
                _    => Pay += 0
            };
        }
        
        public void DisplayStats()
        {
            Console.WriteLine("Nome: {0}", _empName);
            Console.WriteLine("ID {0}", _empId);
            Console.WriteLine("Idade: {0}", _empAge);
            Console.WriteLine("Pagamento: {0}", _currPay);
        }
        #endregion
        
        public enum EmployeePayTypeEnum
        {
            Hourly,
            Salaried,
            Commision
        }
    }
}
