
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/BankovskieScheta")]
	[Route("/Catalogs/BankovskieScheta/{Code}")]
	public class BankovskieSchetaRequest/*���������������������*/: V82.�����������������.���������������,IReturn<BankovskieSchetaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class BankovskieSchetaResponse//��������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/BankovskieSchetas")]
	[Route("/Catalogs/BankovskieSchetas/{Codes}")]
	public class BankovskieSchetasRequest/*���������������������*/: IReturn<List<BankovskieSchetaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public BankovskieSchetasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class BankovskieSchetasResponse//��������������������
	{
		public string Result {get;set;}
	}


	public class BankovskieSchetaService /*���������������������*/ : Service
	{
		public object Any(BankovskieSchetaRequest request)
		{
			return new BankovskieSchetaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(BankovskieSchetaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������.�����������(���������);
				if (������ == null)
				{
					return new BankovskieSchetaResponse() {Result = "��������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������.�����������(1);
			}
		}

		public object Get(BankovskieSchetasRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������.�����������(���������);
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
