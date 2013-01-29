
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/UchenyeZvaniya")]
	[Route("/Catalogs/UchenyeZvaniya/{Code}")]
	public class UchenyeZvaniyaRequest/*������������������*/: V82.�����������������.������������,IReturn<UchenyeZvaniyaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class UchenyeZvaniyaResponse//�����������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/UchenyeZvaniyas")]
	[Route("/Catalogs/UchenyeZvaniyas/{Codes}")]
	public class UchenyeZvaniyasRequest/*������������������*/: IReturn<List<UchenyeZvaniyaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public UchenyeZvaniyasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class UchenyeZvaniyasResponse//�����������������
	{
		public string Result {get;set;}
	}


	public class UchenyeZvaniyaService /*������������������*/ : Service
	{
		public object Any(UchenyeZvaniyaRequest request)
		{
			return new UchenyeZvaniyaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(UchenyeZvaniyaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.������������.�����������(���������);
				if (������ == null)
				{
					return new UchenyeZvaniyaResponse() {Result = "������������ c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.������������.�����������(1);
			}
		}

		public object Get(UchenyeZvaniyasRequest request)
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
