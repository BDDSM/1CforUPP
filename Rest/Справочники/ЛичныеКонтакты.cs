
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/LichnyeKontakty")]
	[Route("/Catalogs/LichnyeKontakty/{Code}")]
	public class LichnyeKontaktyRequest/*��������������������*/: V82.�����������������.��������������,IReturn<LichnyeKontaktyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class LichnyeKontaktyResponse//�������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/LichnyeKontaktys")]
	[Route("/Catalogs/LichnyeKontaktys/{Codes}")]
	public class LichnyeKontaktysRequest/*��������������������*/: IReturn<List<LichnyeKontaktyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public LichnyeKontaktysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class LichnyeKontaktysResponse//�������������������
	{
		public string Result {get;set;}
	}


	public class LichnyeKontaktyService /*��������������������*/ : Service
	{
		public object Any(LichnyeKontaktyRequest request)
		{
			return new LichnyeKontaktyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(LichnyeKontaktyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������.�����������(���������);
				if (������ == null)
				{
					return new LichnyeKontaktyResponse() {Result = "�������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������.�����������(1);
			}
		}

		public object Get(LichnyeKontaktysRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������.�����������(���������);
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
