
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/MestaKHraneniya")]
	[Route("/Catalogs/MestaKHraneniya/{Code}")]
	public class MestaKHraneniyaRequest/*�������������������*/: V82.�����������������.�������������,IReturn<MestaKHraneniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class MestaKHraneniyaResponse//������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/MestaKHraneniyas")]
	[Route("/Catalogs/MestaKHraneniyas/{Codes}")]
	public class MestaKHraneniyasRequest/*�������������������*/: IReturn<List<MestaKHraneniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public MestaKHraneniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class MestaKHraneniyasResponse//������������������
	{
		public string Result {get;set;}
	}


	public class MestaKHraneniyaService /*�������������������*/ : Service
	{
		public object Any(MestaKHraneniyaRequest request)
		{
			return new MestaKHraneniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(MestaKHraneniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������.�����������(���������);
				if (������ == null)
				{
					return new MestaKHraneniyaResponse() {Result = "������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������.�����������(1);
			}
		}

		public object Get(MestaKHraneniyasRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������.�����������(���������);
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
