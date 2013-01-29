
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/KoehfficientyStazha")]
	[Route("/Catalogs/KoehfficientyStazha/{Code}")]
	public class KoehfficientyStazhaRequest/*�����������������������*/: V82.�����������������.�����������������,IReturn<KoehfficientyStazhaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class KoehfficientyStazhaResponse//����������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/KoehfficientyStazhas")]
	[Route("/Catalogs/KoehfficientyStazhas/{Codes}")]
	public class KoehfficientyStazhasRequest/*�����������������������*/: IReturn<List<KoehfficientyStazhaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public KoehfficientyStazhasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class KoehfficientyStazhasResponse//����������������������
	{
		public string Result {get;set;}
	}


	public class KoehfficientyStazhaService /*�����������������������*/ : Service
	{
		public object Any(KoehfficientyStazhaRequest request)
		{
			return new KoehfficientyStazhaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(KoehfficientyStazhaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������.�����������(���������);
				if (������ == null)
				{
					return new KoehfficientyStazhaResponse() {Result = "����������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������.�����������(1);
			}
		}

		public object Get(KoehfficientyStazhasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������.�����������(���������);
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
