
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/DokumentyUdostoveryayushhieLichnost")]
	[Route("/Catalogs/DokumentyUdostoveryayushhieLichnost/{Code}")]
	public class DokumentyUdostoveryayushhieLichnostRequest/*�������������������������������������*/: V82.�����������������.�������������������������������,IReturn<DokumentyUdostoveryayushhieLichnostRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class DokumentyUdostoveryayushhieLichnostResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/DokumentyUdostoveryayushhieLichnosts")]
	[Route("/Catalogs/DokumentyUdostoveryayushhieLichnosts/{Codes}")]
	public class DokumentyUdostoveryayushhieLichnostsRequest/*�������������������������������������*/: IReturn<List<DokumentyUdostoveryayushhieLichnostRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public DokumentyUdostoveryayushhieLichnostsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class DokumentyUdostoveryayushhieLichnostsResponse//������������������������������������
	{
		public string Result {get;set;}
	}


	public class DokumentyUdostoveryayushhieLichnostService /*�������������������������������������*/ : Service
	{
		public object Any(DokumentyUdostoveryayushhieLichnostRequest request)
		{
			return new DokumentyUdostoveryayushhieLichnostResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(DokumentyUdostoveryayushhieLichnostRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������������.�����������(���������);
				if (������ == null)
				{
					return new DokumentyUdostoveryayushhieLichnostResponse() {Result = "������������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������������.�����������(1);
			}
		}

		public object Get(DokumentyUdostoveryayushhieLichnostsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������������.�����������(���������);
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
