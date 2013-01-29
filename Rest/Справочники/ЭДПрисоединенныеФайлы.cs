
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/EHDPrisoedinennyeFajjly")]
	[Route("/Catalogs/EHDPrisoedinennyeFajjly/{Code}")]
	public class EHDPrisoedinennyeFajjlyRequest/*���������������������������*/: V82.�����������������.���������������������,IReturn<EHDPrisoedinennyeFajjlyRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class EHDPrisoedinennyeFajjlyResponse//��������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/EHDPrisoedinennyeFajjlys")]
	[Route("/Catalogs/EHDPrisoedinennyeFajjlys/{Codes}")]
	public class EHDPrisoedinennyeFajjlysRequest/*���������������������������*/: IReturn<List<EHDPrisoedinennyeFajjlyRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public EHDPrisoedinennyeFajjlysRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class EHDPrisoedinennyeFajjlysResponse//��������������������������
	{
		public string Result {get;set;}
	}


	public class EHDPrisoedinennyeFajjlyService /*���������������������������*/ : Service
	{
		public object Any(EHDPrisoedinennyeFajjlyRequest request)
		{
			return new EHDPrisoedinennyeFajjlyResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(EHDPrisoedinennyeFajjlyRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.���������������������.�����������(���������);
				if (������ == null)
				{
					return new EHDPrisoedinennyeFajjlyResponse() {Result = "��������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.���������������������.�����������(1);
			}
		}

		public object Get(EHDPrisoedinennyeFajjlysRequest request)
		{
			var ��������� = new List<V82.�����������������.���������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.���������������������.�����������(���������);
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
