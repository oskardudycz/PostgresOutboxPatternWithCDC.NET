# Postgres Outbox Pattern with CDC and .NET
PoC of doing Outbox Pattern with CDC and .NET

## Links

### WAL
- [Devrim Gündüz -WAL: Everything you want to know](https://www.youtube.com/watch?v=feTihjJJs3g)
- [Thiago - How to use Change Data Capture (CDC) with Postgres](https://dev.to/thiagosilvaf/how-to-use-change-database-capture-cdc-in-postgres-37b8)
- [Ramesh naik E - Change Data Capture(CDC) in PostgreSQL](https://medium.com/@ramesh.esl/change-data-capture-cdc-in-postgresql-7dee2d467d1b)
- [Wal2Json - JSON output plugin for changeset extraction](https://github.com/eulerto/wal2json)
- [AWS Database Blog - Stream changes from Amazon RDS for PostgreSQL using Amazon Kinesis Data Streams and AWS Lambda](https://aws.amazon.com/blogs/database/stream-changes-from-amazon-rds-for-postgresql-using-amazon-kinesis-data-streams-and-aws-lambda/)
- [PGDeltaStream - Streaming Postgres logical replication changes atleast-once over websockets ](https://github.com/hasura/pgdeltastream)
- [Hrvoje Milković - Replicate PostreSQL data to Elasticsearch via Logical replication slots](http://staging.kraken.hr/blog/2018/postgresql-replication-elasticsearch)
- [Azure Database for PostgreSQL—Logical decoding and wal2json for change data capture](https://azure.microsoft.com/en-us/updates/azure-database-for-postgresql-logical-decoding-and-wal2json-for-change-data-capture/)
- [Npgsql - Logical Replication](https://www.npgsql.org/doc/replication.html)
- [Postgresql To Kinesis For Java - Disney Streaming](https://github.com/disneystreaming/pg2k4j)

### Locks
- [Chris Hanks - Turning PostgreSQL into a queue serving 10,000 jobs per second](https://gist.github.com/chanks/7585810)
- [Vlad Mihalcea - How do PostgreSQL advisory locks work](https://vladmihalcea.com/how-do-postgresql-advisory-locks-work/)
- [Marco Slot - When Postgres blocks: 7 tips for dealing with locks](https://www.citusdata.com/blog/2018/02/22/seven-tips-for-dealing-with-postgres-locks/)
- [Marco Slot - PostgreSQL rocks, except when it blocks: Understanding locks](https://www.citusdata.com/blog/2018/02/15/when-postgresql-blocks/)
- [Nickolay Ihalainen - PostgreSQL locking, Part 1: Row Locks](https://www.percona.com/blog/2018/10/16/postgresql-locking-part-1-row-locks/)
- [Nickolay Ihalainen - PostgreSQL locking, part 2: heavyweight locks](https://www.percona.com/blog/2018/10/24/postgresql-locking-part-2-heavyweight-locks/)
- [Nickolay Ihalainen - PostgreSQL locking, part 3: lightweight locks](https://www.percona.com/blog/2018/10/30/postgresql-locking-part-3-lightweight-locks/)

### Outbox implementations
- [Robert Kawecki - esdf2-eventstore-pg](https://github.com/rkaw92/esdf2-eventstore-pg/blob/a49f88cd1f10d4f06a12ef0982293a8c7abb4ff9/src/PostgresEventStore.ts#L116)
