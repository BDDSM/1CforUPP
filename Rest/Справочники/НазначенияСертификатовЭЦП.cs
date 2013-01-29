
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NaznacheniyaSertifikatovEHCP")]
	[Route("/Catalogs/NaznacheniyaSertifikatovEHCP/{Code}")]
	public class NaznacheniyaSertifikatovEHCPRequest/*�������������������������������*/: V82.�����������������.�������������������������,IReturn<NaznacheniyaSertifikatovEHCPRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NaznacheniyaSertifikatovEHCPResponse//������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NaznacheniyaSertifikatovEHCPs")]
	[Route("/Catalogs/NaznacheniyaSertifikatovEHCPs/{Codes}")]
	public class NaznacheniyaSertifikatovEHCPsRequest/*�������������������������������*/: IReturn<List<NaznacheniyaSertifikatovEHCPRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NaznacheniyaSertifikatovEHCPsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NaznacheniyaSertifikatovEHCPsResponse//������������������������������
	{
		public string Result {get;set;}
	}


	public class NaznacheniyaSertifikatovEHCPService /*�������������������������������*/ : Service
	{
		public object Any(NaznacheniyaSertifikatovEHCPRequest request)
		{
			return new NaznacheniyaSertifikatovEHCPResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NaznacheniyaSertifikatovEHCPRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������������.�����������(���������);
				if (������ == null)
				{
					return new NaznacheniyaSertifikatovEHCPResponse() {Result = "������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������������.�����������(1);
			}
		}

		public object Get(NaznacheniyaSertifikatovEHCPsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������������.�����������(���������);
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
