
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/Nomenklatura")]
	[Route("/Catalogs/Nomenklatura/{Code}")]
	public class NomenklaturaRequest/*������������������*/: V82.�����������������.������������,IReturn<NomenklaturaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NomenklaturaResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/Nomenklaturas")]
	[Route("/Catalogs/Nomenklaturas/{Codes}")]
	public class NomenklaturasRequest/*������������������*/: IReturn<List<NomenklaturaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NomenklaturasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NomenklaturasResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class NomenklaturaService /*������������������*/ : Service
	{
		public object Any(NomenklaturaRequest request)
		{
			return new NomenklaturaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NomenklaturaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new NomenklaturaResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(NomenklaturasRequest request)
		{
			var ��������� = new List<V82.�����������������.������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
