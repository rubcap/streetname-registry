## [1.14.7](https://github.com/informatievlaanderen/streetname-registry/compare/v1.14.6...v1.14.7) (2019-09-02)


### Bug Fixes

* do not log to console write ([d67003b](https://github.com/informatievlaanderen/streetname-registry/commit/d67003b))

## [1.14.6](https://github.com/informatievlaanderen/streetname-registry/compare/v1.14.5...v1.14.6) (2019-09-02)


### Bug Fixes

* properly report errors ([b1d02cf](https://github.com/informatievlaanderen/streetname-registry/commit/b1d02cf))

## [1.14.5](https://github.com/informatievlaanderen/streetname-registry/compare/v1.14.4...v1.14.5) (2019-08-29)


### Bug Fixes

* use columnstore for legacy syndication ([8907d63](https://github.com/informatievlaanderen/streetname-registry/commit/8907d63))

## [1.14.4](https://github.com/informatievlaanderen/streetname-registry/compare/v1.14.3...v1.14.4) (2019-08-27)


### Bug Fixes

* make datadog tracing check more for nulls ([b202f8c](https://github.com/informatievlaanderen/streetname-registry/commit/b202f8c))

## [1.14.3](https://github.com/informatievlaanderen/streetname-registry/compare/v1.14.2...v1.14.3) (2019-08-27)


### Bug Fixes

* use new desiredstate columns for projections ([b59c39a](https://github.com/informatievlaanderen/streetname-registry/commit/b59c39a))

## [1.14.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.14.1...v1.14.2) (2019-08-26)


### Bug Fixes

* use fixed datadog tracing ([6b40209](https://github.com/informatievlaanderen/streetname-registry/commit/6b40209))

## [1.14.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.14.0...v1.14.1) (2019-08-26)


### Bug Fixes

* fix swagger ([43c2f7e](https://github.com/informatievlaanderen/streetname-registry/commit/43c2f7e))

# [1.14.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.13.0...v1.14.0) (2019-08-26)


### Features

* bump to .net 2.2.6 ([d6eaf38](https://github.com/informatievlaanderen/streetname-registry/commit/d6eaf38))

# [1.13.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.12.1...v1.13.0) (2019-08-22)


### Features

* extract datavlaanderen namespace to settings [#3](https://github.com/informatievlaanderen/streetname-registry/issues/3) ([e13a831](https://github.com/informatievlaanderen/streetname-registry/commit/e13a831))

## [1.12.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.12.0...v1.12.1) (2019-08-22)


### Bug Fixes

* bosa empty body does not crash anymore GR-855 ([c8aa3fd](https://github.com/informatievlaanderen/streetname-registry/commit/c8aa3fd))
* bosa exact filter takes exact name into account ([0a06aa6](https://github.com/informatievlaanderen/streetname-registry/commit/0a06aa6))
* return empty response when request has invalid data GR-856 ([c18b134](https://github.com/informatievlaanderen/streetname-registry/commit/c18b134))

# [1.12.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.11.0...v1.12.0) (2019-08-16)


### Features

* add wait for user input to importer ([fd1d14e](https://github.com/informatievlaanderen/streetname-registry/commit/fd1d14e))

# [1.11.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.10.7...v1.11.0) (2019-08-13)


### Features

* add missing event handlers where nothing was expected [#29](https://github.com/informatievlaanderen/streetname-registry/issues/29) ([35e315a](https://github.com/informatievlaanderen/streetname-registry/commit/35e315a))

## [1.10.7](https://github.com/informatievlaanderen/streetname-registry/compare/v1.10.6...v1.10.7) (2019-08-09)


### Bug Fixes

* fix container id in logging ([c40607b](https://github.com/informatievlaanderen/streetname-registry/commit/c40607b))

## [1.10.6](https://github.com/informatievlaanderen/streetname-registry/compare/v1.10.5...v1.10.6) (2019-08-06)


### Bug Fixes

* bosa streetname version now offsets to belgian timezone ([7aad2cf](https://github.com/informatievlaanderen/streetname-registry/commit/7aad2cf))
* display municipality languages for bosa search ([755896a](https://github.com/informatievlaanderen/streetname-registry/commit/755896a))

## [1.10.5](https://github.com/informatievlaanderen/streetname-registry/compare/v1.10.4...v1.10.5) (2019-08-05)


### Bug Fixes

* streetname sort bosa is now by PersistentLocalId ([4ae3dd7](https://github.com/informatievlaanderen/streetname-registry/commit/4ae3dd7))

## [1.10.4](https://github.com/informatievlaanderen/streetname-registry/compare/v1.10.3...v1.10.4) (2019-07-17)


### Bug Fixes

* do not hardcode logging to console ([a214c59](https://github.com/informatievlaanderen/streetname-registry/commit/a214c59))

## [1.10.3](https://github.com/informatievlaanderen/streetname-registry/compare/v1.10.2...v1.10.3) (2019-07-15)


### Bug Fixes

* correct datadog inits ([22fc3ec](https://github.com/informatievlaanderen/streetname-registry/commit/22fc3ec))

## [1.10.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.10.1...v1.10.2) (2019-07-10)


### Bug Fixes

* fix migrations extract ([8ca953b](https://github.com/informatievlaanderen/streetname-registry/commit/8ca953b))

## [1.10.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.10.0...v1.10.1) (2019-07-10)


### Bug Fixes

* give the correct name of the event in syndication ([7f70d04](https://github.com/informatievlaanderen/streetname-registry/commit/7f70d04))

# [1.10.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.9.0...v1.10.0) (2019-07-10)


### Features

* rename oslo id to persistent local id ([cd9fbb9](https://github.com/informatievlaanderen/streetname-registry/commit/cd9fbb9))

# [1.9.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.8.4...v1.9.0) (2019-07-05)


### Features

* upgrade Be.Vlaanderen.Basisregisters.Api ([f2dd36b](https://github.com/informatievlaanderen/streetname-registry/commit/f2dd36b))

## [1.8.4](https://github.com/informatievlaanderen/streetname-registry/compare/v1.8.3...v1.8.4) (2019-07-02)


### Bug Fixes

* list now displays correct homonym addition in german & english ([59925af](https://github.com/informatievlaanderen/streetname-registry/commit/59925af))

## [1.8.3](https://github.com/informatievlaanderen/streetname-registry/compare/v1.8.2...v1.8.3) (2019-06-28)


### Bug Fixes

* reference correct packages for documentation ([7d28cd6](https://github.com/informatievlaanderen/streetname-registry/commit/7d28cd6))

## [1.8.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.8.1...v1.8.2) (2019-06-27)


### Bug Fixes

* fix logging for syndication ([6035e2d](https://github.com/informatievlaanderen/streetname-registry/commit/6035e2d))

## [1.8.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.8.0...v1.8.1) (2019-06-27)

# [1.8.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.7.0...v1.8.0) (2019-06-20)


### Features

* upgrade packages for import ([cd25375](https://github.com/informatievlaanderen/streetname-registry/commit/cd25375))

# [1.7.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.6.2...v1.7.0) (2019-06-11)


### Features

* upgrade provenance package Plan -> Reason ([fdb618e](https://github.com/informatievlaanderen/streetname-registry/commit/fdb618e))

## [1.6.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.6.1...v1.6.2) (2019-06-06)


### Bug Fixes

* copy correct repo ([69a609b](https://github.com/informatievlaanderen/streetname-registry/commit/69a609b))

## [1.6.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.6.0...v1.6.1) (2019-06-06)


### Bug Fixes

* force version bump ([d6acf8a](https://github.com/informatievlaanderen/streetname-registry/commit/d6acf8a))

# [1.6.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.5.2...v1.6.0) (2019-06-06)


### Features

* deploy docker to production ([354a707](https://github.com/informatievlaanderen/streetname-registry/commit/354a707))

## [1.5.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.5.1...v1.5.2) (2019-06-06)


### Bug Fixes

* change idempotency hash to be stable ([9cff84f](https://github.com/informatievlaanderen/streetname-registry/commit/9cff84f))

## [1.5.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.5.0...v1.5.1) (2019-05-23)


### Bug Fixes

* correct oslo id type for extract ([f735cd8](https://github.com/informatievlaanderen/streetname-registry/commit/f735cd8))

# [1.5.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.4.2...v1.5.0) (2019-05-22)


### Features

* add event data to sync endpoint ([31bd514](https://github.com/informatievlaanderen/streetname-registry/commit/31bd514))

## [1.4.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.4.1...v1.4.2) (2019-05-21)

## [1.4.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.4.0...v1.4.1) (2019-05-20)

# [1.4.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.12...v1.4.0) (2019-04-30)


### Features

* add projector + cleanup projection libraries ([a861da2](https://github.com/informatievlaanderen/streetname-registry/commit/a861da2))
* upgrade packages ([6d9ad96](https://github.com/informatievlaanderen/streetname-registry/commit/6d9ad96))

## [1.3.12](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.11...v1.3.12) (2019-04-18)

## [1.3.11](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.10...v1.3.11) (2019-04-17)


### Bug Fixes

* [#8](https://github.com/informatievlaanderen/streetname-registry/issues/8) + Volgende is now not emitted if null ([fe6eb46](https://github.com/informatievlaanderen/streetname-registry/commit/fe6eb46))

## [1.3.10](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.9...v1.3.10) (2019-04-16)


### Bug Fixes

* sort streetname list by olsoid [GR-717] ([f62740e](https://github.com/informatievlaanderen/streetname-registry/commit/f62740e))

## [1.3.9](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.8...v1.3.9) (2019-03-06)

## [1.3.8](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.7...v1.3.8) (2019-02-28)


### Bug Fixes

* swagger docs now show list response correctly ([79adcf9](https://github.com/informatievlaanderen/streetname-registry/commit/79adcf9))

## [1.3.7](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.6...v1.3.7) (2019-02-26)

## [1.3.6](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.5...v1.3.6) (2019-02-25)

## [1.3.5](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.4...v1.3.5) (2019-02-25)


### Bug Fixes

* extract only exports completed items ([6baf2e9](https://github.com/informatievlaanderen/streetname-registry/commit/6baf2e9))
* use new lastchangedlist migrations runner ([4d4e0e2](https://github.com/informatievlaanderen/streetname-registry/commit/4d4e0e2))

## [1.3.4](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.3...v1.3.4) (2019-02-07)


### Bug Fixes

* support nullable Rfc3339SerializableDateTimeOffset in converter ([7b3c704](https://github.com/informatievlaanderen/streetname-registry/commit/7b3c704))

## [1.3.3](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.2...v1.3.3) (2019-02-06)


### Bug Fixes

* properly serialise rfc 3339 dates ([abd5daf](https://github.com/informatievlaanderen/streetname-registry/commit/abd5daf))

## [1.3.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.1...v1.3.2) (2019-02-06)


### Bug Fixes

* oslo id and niscode in sync werent correctly projected ([32d9ee8](https://github.com/informatievlaanderen/streetname-registry/commit/32d9ee8))

## [1.3.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.3.0...v1.3.1) (2019-02-04)

# [1.3.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.2.3...v1.3.0) (2019-01-25)


### Bug Fixes

* correctly setting primary language in sync projection ([825ba1a](https://github.com/informatievlaanderen/streetname-registry/commit/825ba1a))
* fix starting Syndication projection ([46788bc](https://github.com/informatievlaanderen/streetname-registry/commit/46788bc))
* list now displays name of streetnames correctly ([d02b6d2](https://github.com/informatievlaanderen/streetname-registry/commit/d02b6d2))


### Features

* adapted sync with new municipality changes ([c05d427](https://github.com/informatievlaanderen/streetname-registry/commit/c05d427))
* change display municipality name of detail in Api.Legacy ([79d693f](https://github.com/informatievlaanderen/streetname-registry/commit/79d693f))

## [1.2.3](https://github.com/informatievlaanderen/streetname-registry/compare/v1.2.2...v1.2.3) (2019-01-22)


### Bug Fixes

* use https for namespace ([92965c1](https://github.com/informatievlaanderen/streetname-registry/commit/92965c1))

## [1.2.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.2.1...v1.2.2) (2019-01-18)

## [1.2.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.2.0...v1.2.1) (2019-01-18)


### Bug Fixes

* migrations history table for syndication ([f78cd51](https://github.com/informatievlaanderen/streetname-registry/commit/f78cd51))

# [1.2.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.1.2...v1.2.0) (2019-01-17)


### Features

* do not take diacritics into account when filtering on municipality ([025a122](https://github.com/informatievlaanderen/streetname-registry/commit/025a122))

## [1.1.2](https://github.com/informatievlaanderen/streetname-registry/compare/v1.1.1...v1.1.2) (2019-01-16)


### Bug Fixes

* required upgrade for datadog tracing to avoid connection pool problems ([432dbb4](https://github.com/informatievlaanderen/streetname-registry/commit/432dbb4))

## [1.1.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.1.0...v1.1.1) (2019-01-16)


### Bug Fixes

* optimise catchup mode for versions ([4583327](https://github.com/informatievlaanderen/streetname-registry/commit/4583327))

# [1.1.0](https://github.com/informatievlaanderen/streetname-registry/compare/v1.0.1...v1.1.0) (2019-01-16)


### Bug Fixes

* legacy syndication now subsribes to OsloIdAssigned ([42f0f49](https://github.com/informatievlaanderen/streetname-registry/commit/42f0f49))
* take local changes into account for versions projection ([9560ec6](https://github.com/informatievlaanderen/streetname-registry/commit/9560ec6))


### Features

* add statuscode 410 Gone for removed streetnames ([4e5f7f6](https://github.com/informatievlaanderen/streetname-registry/commit/4e5f7f6))

## [1.0.1](https://github.com/informatievlaanderen/streetname-registry/compare/v1.0.0...v1.0.1) (2019-01-15)


### Bug Fixes

* streetnameid in extract file is a string ([f845424](https://github.com/informatievlaanderen/streetname-registry/commit/f845424))

# 1.0.0 (2019-01-14)


### Features

* open source with EUPL-1.2 license as 'agentschap Informatie Vlaanderen' ([bba50fd](https://github.com/informatievlaanderen/streetname-registry/commit/bba50fd))
