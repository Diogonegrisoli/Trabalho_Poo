using Hospital.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Interface
{
    public interface IDAO<T>
    {
        void Cadastrar(T t);

        void Atualizar(T t);

        void Deletar(T t);

        List<Pacientes> Selecionar(T t);
    }
}
