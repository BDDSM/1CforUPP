
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SertifikatyEHCP")]
	[Route("/Catalogs/SertifikatyEHCP/{Code}")]
	public class SertifikatyEHCPRequest/*��������������������*/: V82.�����������������.��������������,IReturn<SertifikatyEHCPRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SertifikatyEHCPResponse//�������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SertifikatyEHCPs")]
	[Route("/Catalogs/SertifikatyEHCPs/{Codes}")]
	public class SertifikatyEHCPsRequest/*��������������������*/: IReturn<List<SertifikatyEHCPRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SertifikatyEHCPsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SertifikatyEHCPsResponse//�������������������
	{
		public string Result {get;set;}
	}


	public class SertifikatyEHCPService /*��������������������*/ : Service
	{
		public object Any(SertifikatyEHCPRequest request)
		{
			return new SertifikatyEHCPResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SertifikatyEHCPRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������.�����������(���������);
				if (������ == null)
				{
					return new SertifikatyEHCPResponse() {Result = "�������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������.�����������(1);
			}
		}

		public object Get(SertifikatyEHCPsRequest request)
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
