﻿using APIGestor.Models.Projetos;

namespace APIGestor.Services.XmlProjeto
{

    

    interface IXmlService<T>
    {
        Resultado ValidaXml(int ProjetoId);

        // Projeto obterProjeto(int Id);

        T GerarXml(int ProjetoId, string Versao, string UserId);
    }
}
